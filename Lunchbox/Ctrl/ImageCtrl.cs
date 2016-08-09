using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Lunchbox
{
    internal class ImageCtrl
    {
        private Setting _setting;
        private MainForm _form;

        public ImageCtrl(Setting setting, MainForm form)
        {
            _setting = setting;
            _form = form;
        }

        public Bitmap getTaskTrayImage(int x, int y, int width, int height)
        {
            if ((x > Screen.PrimaryScreen.Bounds.Width)
                || (y > Screen.PrimaryScreen.Bounds.Height)
                || (width < 0)
                || (height < 0))
            {
                return null;
            }

            //画像格納様ビットマップ作成
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppPArgb);

            //描画サーフェイス「using」を使い、自動でGraphicsのDisposeを行っている
            using (Graphics g = Graphics.FromImage(bmp))
            {
                try
                {
                    //画面から色データのビットブロック転送
                    //ここではディスプレイの右上からの画像を
                    //コピー先の座標(0,0)へ
                    //サイズ、色を変更せずコピー
                    g.CopyFromScreen(x, y, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                }
                catch (Exception)
                {
                    // System.ComponentModel.Win32Exception (0x80004005): ハンドルが無効です。
                    // が発生することがある
                }
            }

            //ピクチャボックスへ画像貼り付け
            return bmp;
        }

        // http://tinqwill.blog59.fc2.com/blog-entry-46.html
        public bool compareImage(Image image1, Image image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }

            Bitmap img1 = (Bitmap)image1;
            Bitmap img2 = (Bitmap)image2;

            //高さが違えばfalse
            if (img1.Width != img2.Width || img1.Height != img2.Height) return false;
            //BitmapData取得
            BitmapData bd1 = img1.LockBits(new Rectangle(0, 0, img1.Width, img1.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, img1.PixelFormat);
            BitmapData bd2 = img2.LockBits(new Rectangle(0, 0, img2.Width, img2.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, img2.PixelFormat);
            //スキャン幅が違う場合はfalse
            if (bd1.Stride != bd2.Stride)
            {
                //ロックを解除
                img1.UnlockBits(bd1);
                img2.UnlockBits(bd2);
                return false;
            }
            int bsize = bd1.Stride * img1.Height;
            byte[] byte1 = new byte[bsize];
            byte[] byte2 = new byte[bsize];
            //バイト配列にコピー
            Marshal.Copy(bd1.Scan0, byte1, 0, bsize);
            Marshal.Copy(bd2.Scan0, byte2, 0, bsize);
            //ロックを解除
            img1.UnlockBits(bd1);
            img2.UnlockBits(bd2);

            //MD5ハッシュを取る
            System.Security.Cryptography.MD5CryptoServiceProvider md5 =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hash1 = md5.ComputeHash(byte1);
            byte[] hash2 = md5.ComputeHash(byte2);

            //ハッシュを比較
            return hash1.SequenceEqual(hash2);
        }
    }
}
