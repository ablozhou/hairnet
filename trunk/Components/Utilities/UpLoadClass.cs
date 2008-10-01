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
using HairNet.Enumerations;


namespace HairNet.Utilities
{
    public class UpLoadClass
    {
        public UpLoadClass()
        {
 
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fileCollection">上传文件集合</param>
        /// <param name="fileSize">上传文件限制大小</param>
        /// <param name="uploadFileType">上传文件所属分类</param>
        /// <param name="upLoadPath">上传文件路径（如："images/emotionUploadFile"）</param>
        /// <returns>上传文件的文件名</returns>
        public string UploadFileOperate(HttpFileCollection fileCollection, int fileSize, UpLoadFileType uploadFileType, string upLoadPath)
        {
            try
            {
                StringBuilder fileName = new StringBuilder("");
           
                switch (uploadFileType)
                {
                    case UpLoadFileType.newsUploadFile:
                        for (int i = 0; i < fileCollection.Count; i++)
                        {
                            fileName.Append( this.UpLoadFile(fileCollection[i], upLoadPath, fileSize,i));
                        }
                        break;
                    case UpLoadFileType.identityUploadFile:
                        for (int i = 0; i < fileCollection.Count; i++)
                        {
                            fileName.Append(this.UpLoadFile(fileCollection[i], upLoadPath, fileSize,i));
                        }
                        break;
                    case UpLoadFileType.customUploadFile:
                        for (int i = 0; i < fileCollection.Count; i++)
                        {
                            fileName.Append(this.UpLoadFile(fileCollection[i], upLoadPath, fileSize,i));
                        }
                        break;
                    default:
                        for (int i = 0; i < fileCollection.Count; i++)
                        {
                            fileName.Append(this.UpLoadFile(fileCollection[i], upLoadPath, fileSize,i));
                        }
                        break;
                }
                return fileName.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);  
                //return "上传失败！";
            }
        }
        /// <summary>
        /// 定义上传文件的文件名
        /// </summary>
        /// <returns>返回定义的文件名</returns>
        public string GetUploadFileName()
        {
            DateTime now = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(now.ToString("yyyymmddhhmmss"));
            sb.Append(now.Millisecond.ToString());
            return sb.ToString();
        }
        /// <summary>
        /// 上传文件操作
        /// </summary>
        /// <param name="postedFile">上传对象</param>
        /// <param name="upLoadPath">上传路径</param>
        /// <param name="fileSize">上传大小</param>
        /// <returns></returns>
        public string UpLoadFile(HttpPostedFile postedFile,string upLoadPath,int fileSize,int i)
        {
            StringBuilder fileName = new StringBuilder("");
            if (postedFile.ContentType != "application/x-javascript" || postedFile.ContentType != "text/asp")
            {
                if (postedFile.ContentLength <= fileSize)
                {
                    string filename = this.GetUploadFileName() + i.ToString();
                    fileName.Append(filename + Path.GetExtension(postedFile.FileName).ToString() + "<br>");
                    postedFile.SaveAs(System.Web.HttpContext.Current.Server.MapPath(upLoadPath) +"/"+ filename+Path.GetExtension(postedFile.FileName).ToString());
                }
            }
            return fileName.ToString();
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fileUrl">文件全路径路径</param>
        /// <returns>删除是否成功</returns>
        public bool DeleteFile(string fileUrl)
        {
            try
            {
                string fullPath = HttpContext.Current.Server.MapPath(fileUrl);
                File.Delete(fullPath);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
                //return false;
            }
        }
        /// <summary>
        /// 删除目录文件
        /// </summary>
        /// <param name="directoryUrl">目录全路径</param>
        /// <returns>删除是否成功</returns>
        public bool DeleteDirectory(string directoryUrl)
        {
            try
            {
                string fullPath = HttpContext.Current.Server.MapPath(directoryUrl);
                Directory.Delete(fullPath);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
                //return false;
            }
        }

        public string UpLoadImg(HtmlInputFile upload_img,string pathSave)
        {
            int error = 0;
            string filename = "";
            string FN = "";
            if (upload_img.PostedFile == null || upload_img.PostedFile.FileName.Length < 3)
            {
                HttpContext.Current.Response.Write("<script>alert('请先选择一个文件再点上传。');</script>");
                error = 1;
            }
            else
            {
                if (upload_img.PostedFile.ContentLength > 10240000)
                {
                    HttpContext.Current.Response.Write("<script>alert('文件大约10M，不能上传。');</script>");
                    error = 1;
                }
            }
            if (error == 0)
            {
                string pathname = upload_img.PostedFile.FileName;
                string name = pathname.Substring(pathname.LastIndexOf(@"\") + 1);
                string path = System.Web.HttpContext.Current.Server.MapPath(pathSave);
                string y = DateTime.Now.Year.ToString();
                string m = DateTime.Now.Month.ToString();
                string d = DateTime.Now.Day.ToString();
                string h = DateTime.Now.Hour.ToString();
                string n = DateTime.Now.Minute.ToString();
                string s = DateTime.Now.Second.ToString();
                filename = y + m + d + h + n + s;
                FileOperate fileOpeater = new FileOperate();
                fileOpeater.NewDirectory(path, y, m, d);
                Random r = new Random();
                filename = y + "/" + m + "/" + d + "/" +"images"+"/"+ filename + r.Next(100000000);
                filename = filename + "." + name.Substring(name.Length - 3);
                FN = pathSave + filename;
                filename = path + "/" + filename;
                upload_img.PostedFile.SaveAs(filename);
            }
            return FN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileUpload">fileUpload</param>
        /// <param name="path">path</param>
        /// <returns></returns>
        public String UploadImageFile(FileUpload fileUpload, string path)
        {
            string FN = String.Empty;

            try
            {
                if (!fileUpload.HasFile || fileUpload.FileName.Length < 3)
                {
                    HttpContext.Current.Response.Write("<script>alert('请先选择一个文件再点上传。');</script>");
                }

                if (fileUpload.PostedFile.InputStream.Length > 10240000)
                {
                    HttpContext.Current.Response.Write("<script>alert('文件大约10M，不能上传。');</script>");
                }

                string name = fileUpload.PostedFile.FileName.Substring(fileUpload.PostedFile.FileName.LastIndexOf(@"\") + 1);
                string pathSave = System.Web.HttpContext.Current.Server.MapPath(path); ;

                string y = DateTime.Now.Year.ToString();
                string m = DateTime.Now.Month.ToString();
                string d = DateTime.Now.Day.ToString();
                string h = DateTime.Now.Hour.ToString();
                string n = DateTime.Now.Minute.ToString();
                string s = DateTime.Now.Second.ToString();

                string filename = y + m + d + h + n + s;
                FileOperate fileOpeater = new FileOperate();
                fileOpeater.NewDirectory(pathSave, y, m, d);

                Random r = new Random();
                filename = y + "\\" + m + "\\" + d + "\\" + "images" + "\\" + filename + r.Next(100000000);
                filename = filename + "." + name.Substring(name.Length - 3);
                FN = pathSave + filename;
                filename = pathSave + "\\" + filename;

                fileUpload.PostedFile.SaveAs(filename);
            }
            catch (IOException ioEx)
            { throw ioEx; }

            return FN;
        }
    }
}
