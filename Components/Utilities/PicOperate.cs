using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using ImageQuantization;

namespace HairNet.Utilities
{
    public class PicOperate
    {
        public PicOperate()
        {
            
        }
        /// <summary>
        /// 生成图片缩略图
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <param name="header">文件目录</param>
        /// <param name="microPicNum">生成的数量</param>
        /// <param name="width">对应的宽度</param>
        /// <param name="height">对应的高度</param>
        /// <returns>修改图片的所有所略图名称集合</returns>
        public string CreateMicroPic(string fileName,string header,int microPicNum, int[] microPicWidth, int[] microPicHeight) 
        {
            string micFileFullName = "";
            string picPath = header + "/" + fileName.ToLower();
            for (int i = 0; i < microPicNum; i++)
            {
                //缩略图路径是目录+文件名+缩略图标签+扩展名
                string createdPicPath = header + fileName.Substring(0, fileName.LastIndexOf(".")) + Convert.ToString(i + 1) + Path.GetExtension(fileName);
                Bitmap bitmap = new Bitmap(System.Web.HttpContext.Current.Server.MapPath(picPath));
                float fWidth = float.Parse(bitmap.Width.ToString());
                float fHeight = float.Parse(bitmap.Height.ToString());
                if (bitmap.Width == bitmap.Height)
                {
                    if (bitmap.Width > microPicWidth[i])
                    {
                        this.ConvertOperate(bitmap, microPicWidth[i], microPicHeight[i], createdPicPath);
                    }
                    else
                    {
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }
 
                }
                else if (bitmap.Width > bitmap.Height)
                {
                    
                    if (bitmap.Width > microPicWidth[i])
                    {
                        float scale = fWidth / fHeight;
                        this.ConvertOperate(bitmap, microPicWidth[i], Convert.ToInt32(microPicWidth[i] / scale), createdPicPath);
                    }
                    else
                    {  
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }
                }
                else
                {
                    if (bitmap.Height > microPicHeight[i])
                    {
                        float scale = fWidth / fHeight;
                        this.ConvertOperate(bitmap, Convert.ToInt32(microPicHeight[i] * scale), microPicHeight[i], createdPicPath); 
                    }
                    else
                    {
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }
                }
                micFileFullName += createdPicPath.ToString() + "<br>";
            }
            return micFileFullName.ToString();
        }
        /// <summary>
        /// 生成单张图片缩略图
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="header"></param>
        /// <param name="microPicWidth"></param>
        /// <param name="microPicHeight"></param>
        /// <returns></returns>
        public string CreateMicroPic(string fileName, string header, int microPicWidth, int microPicHeight)
        {
            string micFileFullName = "";
            string picPath = header + fileName.ToLower();
                //缩略图路径是目录+文件名+缩略图标签+扩展名
                string createdPicPath = header + fileName.Substring(0, fileName.LastIndexOf(".")) + "a"+ Path.GetExtension(fileName);
                Bitmap bitmap = new Bitmap(System.Web.HttpContext.Current.Server.MapPath(picPath));
                float fWidth = float.Parse(bitmap.Width.ToString());
                float fHeight = float.Parse(bitmap.Height.ToString());
                if (bitmap.Width == bitmap.Height)
                {
                    if (bitmap.Width > microPicWidth)
                    {
                        this.ConvertOperate(bitmap, microPicWidth, microPicHeight, createdPicPath);
                    }
                    else
                    {
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }

                }
                else if (bitmap.Width > bitmap.Height)
                {

                    if (bitmap.Width > microPicWidth)
                    {
                        float scale = fWidth / fHeight;
                        this.ConvertOperate(bitmap, microPicWidth, Convert.ToInt32(microPicWidth / scale), createdPicPath);
                    }
                    else
                    {
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }
                }
                else
                {
                    if (bitmap.Height > microPicHeight)
                    {
                        float scale = fWidth / fHeight;
                        this.ConvertOperate(bitmap, Convert.ToInt32(microPicHeight * scale), microPicHeight, createdPicPath);
                    }
                    else
                    {
                        this.ConvertOperate(bitmap, bitmap.Width, bitmap.Height, createdPicPath);
                    }
                }
                micFileFullName = createdPicPath.ToString();
            return micFileFullName.ToString();
        }

        /// <summary>
        /// 转换操作
        /// </summary>
        /// <param name="bitmap">转换的图片</param>
        /// <param name="width">转换的宽度</param>
        /// <param name="height">转换的高度</param>
        /// <param name="createdPicPath">转换图片的保存路径</param>
        public void ConvertOperate(Bitmap bitmap, int width, int height, string createdPicPath)
        {
            Bitmap micPicBMP = new Bitmap(bitmap, width, height);
            //(this.QuantizationPic(micPicBMP)).Save(System.Web.HttpContext.Current.Server.MapPath(createdPicPath), System.Drawing.Imaging.ImageFormat.Jpeg);
            OctreeQuantizer quantizer = new OctreeQuantizer(255, 8);
            using (Bitmap quantized = quantizer.Quantize(micPicBMP))
            {
                quantized.Save(System.Web.HttpContext.Current.Server.MapPath(createdPicPath), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            bitmap.Dispose();
        }
        /// <summary>
        /// 添加水印操作1
        /// </summary>
        /// <param name="picPath">想要水印的图片路径</param>
        /// <param name="picWaterMarkPath">水银图片路径</param>
        /// <param name="copyrighttext">版权文字</param>
        public void AddWaterMarkOperate(string picPath,string picWaterMarkPath,string picAddedWaterMarkPath,string copyrighttext)
        {
            //1
            System.Drawing.Image imgPhoto = System.Drawing.Image.FromFile(picPath);
            int phWidth = imgPhoto.Width; 
            int phHeight =imgPhoto.Height;
            Bitmap bmPhoto = new Bitmap(phWidth, phHeight,PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //2
            System.Drawing.Image imgWatermark = new Bitmap(picWaterMarkPath);
            int wmWidth = imgWatermark.Width;
            int wmHeight = imgWatermark.Height;

            //11
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(imgPhoto,new Rectangle(0, 0, phWidth, phHeight),0,0,phWidth,phHeight,GraphicsUnit.Pixel);

            //22
            int[] sizes = new int[] { 16, 14, 12, 10, 8, 6, 4 };
            Font crFont = null;
            SizeF crSize = new SizeF();
            for (int i = 0; i < 7; i++)
            {
                crFont = new Font("arial", sizes[i],
                                             FontStyle.Bold);
                crSize = grPhoto.MeasureString(copyrighttext,
                                                     crFont);

                if ((ushort)crSize.Width < (ushort)phWidth)
                    break;
            }
            //33
            int yPixlesFromBottom = (int)(phHeight * .05);
            float yPosFromBottom = ((phHeight -
                       yPixlesFromBottom) - (crSize.Height / 2));
            float xCenterOfImg = (phWidth / 2);

            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //44
            SolidBrush semiTransBrush2 =new SolidBrush(Color.FromArgb(153, 0, 0, 0));

            grPhoto.DrawString(copyrighttext,
                crFont,
                semiTransBrush2,
                new PointF(xCenterOfImg + 1, yPosFromBottom + 1),
                StrFormat);

            SolidBrush semiTransBrush = new SolidBrush(
                         Color.FromArgb(153, 255, 255, 255));

            grPhoto.DrawString(copyrighttext,
                crFont,
                semiTransBrush,
                new PointF(xCenterOfImg, yPosFromBottom),
                StrFormat);


            //3
            Bitmap bmWatermark = new Bitmap(bmPhoto);
            bmWatermark.SetResolution(imgPhoto.HorizontalResolution,imgPhoto.VerticalResolution);

            Graphics grWatermark =Graphics.FromImage(bmWatermark);

            //4
            ImageAttributes imageAttributes =new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };

            imageAttributes.SetRemapTable(remapTable,ColorAdjustType.Bitmap);

            //5
            float[][] colorMatrixElements = { 
               new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
               new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
               new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
               new float[] {0.0f,  0.0f,  0.0f,  0.3f, 0.0f},
               new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
            };

            ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,ColorMatrixFlag.Default,ColorAdjustType.Bitmap);

            //位置
            int xPosOfWm = ((phWidth - wmWidth)-10);
            int yPosOfWm = ((phHeight - wmHeight) -10);

            grWatermark.DrawImage(imgWatermark,new Rectangle(xPosOfWm, yPosOfWm, wmWidth,wmHeight),0,0,wmWidth,wmHeight,GraphicsUnit.Pixel,imageAttributes);
            
            //7
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

             
            imgPhoto.Save(picAddedWaterMarkPath,ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgWatermark.Dispose();
        }
        /// <summary>
        /// 添加水印操作2
        /// </summary>
        /// <param name="picPath">想要水印的图片路径</param>
        /// <param name="picWaterMarkPath">水银图片路径</param>
        /// <param name="copyrighttext">版权文字</param>
        public void AddWaterMarkOperate(Bitmap bitmap, string picWaterMarkPath, string picAddedWaterMarkPath, string copyrighttext)
        {
            //1
            System.Drawing.Image imgPhoto = bitmap;
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;
            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //2
            System.Drawing.Image imgWatermark = new Bitmap(picWaterMarkPath);
            int wmWidth = imgWatermark.Width;
            int wmHeight = imgWatermark.Height;

            //11
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(imgPhoto, new Rectangle(0, 0, phWidth, phHeight), 0, 0, phWidth, phHeight, GraphicsUnit.Pixel);

            //22
            int[] sizes = new int[] { 16, 14, 12, 10, 8, 6, 4 };
            Font crFont = null;
            SizeF crSize = new SizeF();
            for (int i = 0; i < 7; i++)
            {
                crFont = new Font("arial", sizes[i],
                                             FontStyle.Bold);
                crSize = grPhoto.MeasureString(copyrighttext,
                                                     crFont);

                if ((ushort)crSize.Width < (ushort)phWidth)
                    break;
            }
            //33
            int yPixlesFromBottom = (int)(phHeight * .05);
            float yPosFromBottom = ((phHeight -
                       yPixlesFromBottom) - (crSize.Height / 2));
            float xCenterOfImg = (phWidth / 2);

            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //44
            SolidBrush semiTransBrush2 = new SolidBrush(Color.FromArgb(153, 0, 0, 0));

            grPhoto.DrawString(copyrighttext,
                crFont,
                semiTransBrush2,
                new PointF(xCenterOfImg + 1, yPosFromBottom + 1),
                StrFormat);

            SolidBrush semiTransBrush = new SolidBrush(
                         Color.FromArgb(153, 255, 255, 255));

            grPhoto.DrawString(copyrighttext,
                crFont,
                semiTransBrush,
                new PointF(xCenterOfImg, yPosFromBottom),
                StrFormat);


            //3
            Bitmap bmWatermark = new Bitmap(bmPhoto);
            bmWatermark.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grWatermark = Graphics.FromImage(bmWatermark);

            //4
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };

            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

            //5
            float[][] colorMatrixElements = { 
               new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
               new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
               new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
               new float[] {0.0f,  0.0f,  0.0f,  0.3f, 0.0f},
               new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
            };

            ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //位置
            int xPosOfWm = ((phWidth - wmWidth) - 10);
            int yPosOfWm = ((phHeight - wmHeight) - 10);

            grWatermark.DrawImage(imgWatermark, new Rectangle(xPosOfWm, yPosOfWm, wmWidth, wmHeight), 0, 0, wmWidth, wmHeight, GraphicsUnit.Pixel, imageAttributes);

            //7
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();


            imgPhoto.Save(picAddedWaterMarkPath, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgWatermark.Dispose();
        }
        /// <summary>
        /// 优化图片
        /// </summary>
        /// <param name="bitmap">要优化的图片</param>
        /// <returns>优化过的图片</returns>
        public Bitmap QuantizationPic(Bitmap bitmap)
        {
            OctreeQuantizer quantizer = new OctreeQuantizer(255, 8);
            using (Bitmap quantized = quantizer.Quantize(bitmap))
            {
                return quantized;
            }
        }
    }
}
