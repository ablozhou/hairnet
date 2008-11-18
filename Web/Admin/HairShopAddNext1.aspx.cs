using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using HairNet.Utilities;
using System.Data.SqlClient;
using HairNet.Entry;
using System.Text;
using HairNet.Components.BackendBusiness;

namespace Web.Admin
{
    public partial class HairShopAddNext1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {   
                string id = this.Request.QueryString["id"].ToString();
                Session["oo"] = string.Empty;

                try
                {
                    string oo = this.Request.QueryString["update"].ToString();
                    Session["oo"] = oo;
                }
                catch (Exception ex)
                {
                    //throw new Exception(ex.Message);
                }
                if (Session["oo"] != null && Session["oo"].ToString() != string.Empty)
                {
                    this.btnSubmit.Text = "��������������";
                }
                string outString = string.Empty;
                string innerString = string.Empty;
                string outpics=string.Empty;
                string inpics = string.Empty;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=2 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;
                       
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {
                                    outpics = "[img]http://hair.sg.com.cn" + sdr["picurl"].ToString().Replace(@"\", @"/") + "[/img]\n";
                                    outString = "<img width=100 heigth=50 src='" + sdr["picsmallurl"].ToString() + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?type=out&id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>ɾ��</a>";
                                }
                                else
                                {
                                    outpics += "[img]http://hair.sg.com.cn" + sdr["picurl"].ToString().Replace(@"\", @"/") + "[/img]\n";
                                    outString += "&nbsp;&nbsp;<img width=100 heigth=50 src='" + sdr["picsmallurl"].ToString() + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?type=out&id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>ɾ��</a>";
                                }
                            }
                            ViewState["outpics"] = outpics;
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=1 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {
                                    inpics = "[img]http://hair.sg.com.cn" + sdr["picurl"].ToString().Replace(@"\", @"/") + "[/img]\n";
                                    innerString = "<img width=100 heigth=50 src='" + sdr["picsmallurl"].ToString() + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?type=inner&id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>ɾ��</a>";
                                }
                                else
                                {
                                    inpics += "[img]http://hair.sg.com.cn" + sdr["picurl"].ToString().Replace(@"\", @"/") + "[/img]\n";
                                    innerString += "&nbsp;&nbsp;<img width=100 heigth=50 src='" + sdr["picsmallurl"].ToString() + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?type=inner&id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>ɾ��</a>";
                                }
                            }
                            ViewState["inpics"] = inpics;
                        }
                    }
                }
                

                this.lblInnerString.Text = innerString;
                this.lblOutString.Text = outString;
            }
        }
        
        public void btnSubmitOut_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(out1c.Value)))
            {
                this.lblInfo.Text = "�ϴ�ͼƬ��ʽ����";
                this.lblInfo.Visible = true;
                return;
            }   

            string out1 = upload.UpLoadImg(out1c, "/uploadfiles/pictures/");
            System.Threading.Thread.Sleep(1000);
            string outsmall1 = upload.UpLoadImg(outSmall, "/uploadfiles/pictures/");
            if (out1 != string.Empty)
            {
                string outid = "";
                //������2,������1
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,picsmallurl,hairshopID,classid) values('" + out1 + "','"+outsmall1+"'," + id.ToString() + ",2);select @@identity;";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            outid = comm.ExecuteScalar().ToString(); 
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairShop set OutLogs=OutLogs+'," + outid + "' where HairShopID=" + id;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                if (Session["oo"] != null && Session["oo"].ToString() != string.Empty)
                {
                    this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString()+"&update=update");
                }
                else
                {
                    this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
                }
            }
        }
        public void btnSubmitInner_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(inner1c.Value)))
            {
                this.lblInfo.Text = "�ϴ�ͼƬ��ʽ����";
                this.lblInfo.Visible = true;
                return;
            } 

            string inner1 = upload.UpLoadImg(inner1c, "/uploadfiles/pictures/");
            System.Threading.Thread.Sleep(1000);
            string innersmall1 = upload.UpLoadImg(innerSmall,"/uploadfiles/pictures/");

            if (inner1 != string.Empty)
            {
                string innerid = "";
                //������2,������1
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,picsmallurl,hairshopID,classid) values('" + inner1 + "','"+innersmall1+"'," + id.ToString() + ",1);select @@identity;";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            innerid = comm.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairShop set innerLogs=innerLogs+'," + innerid + "' where HairShopID=" + this.Request.QueryString["id"].ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }

                if (Session["oo"] != null && Session["oo"].ToString() != string.Empty)
                {
                    this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString() + "&update=update");
                }
                else
                {
                    this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
                }
            }
        }


        public string buildBBSContent(HairShop hs)
        {
            StringBuilder cntBuilder = new StringBuilder();
            //foreach (string i in outpics)
            //{
            //    cntBuilder.AppendLine(i + ",");
            //}
            //foreach (string i in inpics)
            //{
            //    cntBuilder.AppendLine(i + ",");
            //}
            cntBuilder.AppendLine(ViewState["outpics"].ToString());
            cntBuilder.AppendLine(ViewState["inpics"].ToString());

            cntBuilder.AppendLine("��ַ��" + hs.HairShopAddress + "\n");
            cntBuilder.AppendLine("��ͨ��" + hs.LocationMapURL + "\n");
            cntBuilder.AppendLine("�����" + hs.Square.ToString() + "\n");
            if (hs.IsPostStation)
            {
                cntBuilder.AppendLine("�Ƿ���ͣ��λ���� \n");
            }
            else
            {
                cntBuilder.AppendLine("�Ƿ���ͣ��λ���� \n");
            }
            if (hs.IsPostMachine)
            {
                cntBuilder.AppendLine("�Ƿ����ˢ�������� \n");
            }
            else
            {
                cntBuilder.AppendLine("�Ƿ����ˢ���������� \n");
            }
            cntBuilder.AppendLine("Ӫҵʱ�䣺" + hs.HairShopOpenTime.ToString() + "\n");
            cntBuilder.AppendLine(" ���" + hs.TypeName);
            cntBuilder.AppendLine(" �����Ʒ��" + hs.ProductsName);//InfoAdmin.GetProductByProductID+
            cntBuilder.AppendLine(" �ۿۣ�" + hs.HairShopDiscount.ToString());
            cntBuilder.AppendLine(" ԤԼ�绰��" + hs.HairShopPhoneNum );
            cntBuilder.AppendLine(" ��������飺" + hs.HairShopDescription);
            cntBuilder.AppendLine(" ԭ�ģ�http://hair.sg.com.cn/HairShopContent.aspx?id=" + hs.HairShopID.ToString() );
            return cntBuilder.ToString();
        }
        public void btnSubmit_OnClick(object sender,EventArgs e)
        {
            HairShop hs = (HairShop) Session["HairShop"];
            int postid = 0;
            if (hs != null)
            {
                string content = buildBBSContent(hs);
                BBSPost post = new BBSPost();
                bool bSuc = post.AddPost(hs.HairShopName, content, BBSPost.Category.HairShop, out postid);
                if (bSuc)
                {
                    hs.Postid = postid;
                    //update Hairshop.postid
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update HairShop set postid="+hs.Postid.ToString() + " where HairShopID=" + this.Request.QueryString["id"].ToString();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();
                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }
            }

            if (Session["oo"] == null || Session["oo"].ToString() == string.Empty)
            {
                this.Response.Redirect("HairEngineerAdd.aspx");
            }
            else
            {
                Session["oo"] = string.Empty;
                this.Response.Redirect("HairShopAdmin.aspx");
            }
        }
    }
}
