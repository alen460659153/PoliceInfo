using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Drawing;
using DAL;
using Models;
using System.Drawing.Imaging;

namespace PoliceInfo
{
    public class WriteToExcel
    {
        private string deskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private ServicesPersonInfo servicesInfo = new ServicesPersonInfo();
        public bool WriteDataToExcel(DataGridView dgv)
        {
            XSSFWorkbook wb = new XSSFWorkbook();
            ISheet ws = wb.CreateSheet("PersonInfo");
            //设置Sheet的列宽
            ws.SetColumnWidth(0, 10 * 256);  //序号
            ws.SetColumnWidth(1, 14 * 256); //照片
            ws.SetColumnWidth(2, 8 * 256); //姓名
            ws.SetColumnWidth(3, 25 * 256); //列管时间
            ws.SetColumnWidth(4, 4 * 256); //性别
            ws.SetColumnWidth(5, 4 * 256); //年龄
            ws.SetColumnWidth(6, 25 * 256);  //身份证号码           
            ws.SetColumnWidth(7, 38 * 256); //住址
            ws.SetColumnWidth(8, 25 * 256); //涉案类型
            ws.SetColumnWidth(9, 25* 256); //案情
            ws.SetColumnWidth(10, 38 * 256);  //管控记录
            ws.SetColumnWidth(11, 8 * 256);   //同案犯
            ws.SetColumnWidth(12, 8 * 256);  //现状
            ws.SetColumnWidth(13, 14 * 256); //联系电话
            //设置表头
            XSSFFont font = new XSSFFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = 12;  //设置字号12
            font.IsBold = true;
            ICellStyle style = wb.CreateCellStyle();
            style.SetFont(font);
            style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Orange.Index;
            style.FillPattern = FillPattern.SolidForeground;
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;

            IRow rowHeader = ws.CreateRow(0);
            rowHeader.Height = 400;
            rowHeader.CreateCell(0, CellType.String).SetCellValue("序号");
            rowHeader.GetCell(0).CellStyle = style;
            rowHeader.CreateCell(1, CellType.String).SetCellValue("照片");
            rowHeader.GetCell(1).CellStyle = style;
            rowHeader.CreateCell(2, CellType.String).SetCellValue("姓名");
            rowHeader.GetCell(2).CellStyle = style;
            rowHeader.CreateCell(3, CellType.String).SetCellValue("列管时间");
            rowHeader.GetCell(3).CellStyle = style;

            rowHeader.CreateCell(4, CellType.String).SetCellValue("性别");
            rowHeader.GetCell(4).CellStyle = style;
            rowHeader.CreateCell(5, CellType.String).SetCellValue("年龄");
            rowHeader.GetCell(5).CellStyle = style;
            rowHeader.CreateCell(6, CellType.String).SetCellValue("身份证号码");
            rowHeader.GetCell(6).CellStyle = style;
            rowHeader.CreateCell(7, CellType.String).SetCellValue("住址");
            rowHeader.GetCell(7).CellStyle = style;
            rowHeader.CreateCell(8, CellType.String).SetCellValue("涉案类型");
            rowHeader.GetCell(8).CellStyle = style;
            rowHeader.CreateCell(9, CellType.String).SetCellValue("案情");
            rowHeader.GetCell(9).CellStyle = style;
            rowHeader.CreateCell(10,CellType.String).SetCellValue("管控记录");
            rowHeader.GetCell(10).CellStyle = style;
            rowHeader.CreateCell(11, CellType.String).SetCellValue("同案犯");
            rowHeader.GetCell(11).CellStyle = style;
            rowHeader.CreateCell(12, CellType.String).SetCellValue("现状");
            rowHeader.GetCell(12).CellStyle = style;
            rowHeader.CreateCell(13, CellType.String).SetCellValue("联系电话");
            rowHeader.GetCell(13).CellStyle = style;

            XSSFFont font1 = new XSSFFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = 12;  //设置字号12
            XSSFCellStyle style1 =(XSSFCellStyle)wb.CreateCellStyle();
            style1.SetFont(font1);
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            XSSFDataFormat format =(XSSFDataFormat)wb.CreateDataFormat();
            style1.SetDataFormat(format.GetFormat("@"));

            string path = string.Empty;
            if (dgv != null)
            {
                int rowLine = 1;   //从第二行开始
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    DataGridViewRow dgvRow = dgv.Rows[i];
                    IRow iRow = ws.CreateRow(i + 1);
                    iRow.Height = 1200;
                    Image pic = (Image)new SerializeObjectToString().DeserializeObject(dgvRow.Cells["PicImage"].Value.ToString());
                    byte[] b = this.ImageToByte(pic);
                    int pictureIdx = wb.AddPicture(b, PictureType.JPEG);
                    IDrawing draw = ws.CreateDrawingPatriarch();
                    XSSFClientAnchor anchor = new XSSFClientAnchor(30, 30, 30, 30, 1, rowLine, 2, rowLine + 1);
                    XSSFPicture pict = (XSSFPicture)draw.CreatePicture(anchor, pictureIdx);
                    rowLine++;
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (j != 1)
                        {
                            ICell cell = iRow.CreateCell(j);
                            cell.CellStyle = style1;
                            cell.SetCellValue(dgvRow.Cells[j].Value.ToString());
                        }
                    }
                }
                path = deskTopPath + "\\数据导出-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            }
            else
            {             
                for (int i = 0; i < 3; i++)
                {
                    IRow iRow = ws.CreateRow(i + 1);
                    iRow.Height = 1200;
                    for (int j = 0; j < 10; j++)
                    {
                        ICell cell = iRow.CreateCell(j);
                        cell.CellStyle = style1;
                    }
                }
                path = deskTopPath + "\\模板文件-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            }
            using (Stream stream = File.OpenWrite(path))
            {
                wb.Write(stream);
                return true;
            }
        }

        private byte[] ImageToByte(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private Image ByteToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }
        public string InputPerson(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            XSSFWorkbook wb = new XSSFWorkbook(stream);
            ISheet ws = wb.GetSheetAt(0);   //获取第一个Sheet
            int rowCount = ws.LastRowNum;
            if (rowCount == 0)
            {
                wb.Close();
                return "导入失败！当前您选择的Excel文件当中无数据";
            }
            string[] array = new string[] { "序号", "照片", "姓名", "列管时间","性别", "年龄", "身份证号码", "住址","涉案类型","案情","管控记录", "同案犯", "现状", "联系电话" };
            IRow row = ws.GetRow(0);
            for (int i = 0; i < array.Length; i++)
            {
                ICell cell = row.GetCell(i);
                string result = string.Empty;
                if (cell.CellType == CellType.Numeric)
                {
                    result = cell.NumericCellValue.ToString();
                }
                else
                {
                    result = cell.StringCellValue;
                }
                if (result != array[i])
                {
                    wb.Close();
                    return "导入失败！您选择的文件不正确，第【" + (i + 1) + "】列必须为【" + array[i] + "】，请核实后重试！";
                }
            }
            List<PicturesInfo> list = NpoiExtend.GetAllPictureInfos(ws);
            for (int i = 1; i <= rowCount; i++)
            {
                IRow iRow = ws.GetRow(i);
                ICell cell = iRow.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK);  //序号
                string result = string.Empty;
                if (cell.CellType == CellType.Numeric)
                {
                    result = cell.NumericCellValue.ToString();
                }
                else
                {
                    result = cell.StringCellValue;
                }
                try
                {
                    PersonInfo obj = new PersonInfo();
                    obj.PersonName = iRow.GetCell(2, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.LGTime =Convert.ToDateTime(iRow.GetCell(3, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue).Date;
                    obj.Gender = iRow.GetCell(4, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    ICell cell2 = iRow.GetCell(5, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                    if (cell2.CellType==CellType.Numeric)
                    {
                        obj.Age =(int)cell2.NumericCellValue;
                    }
                    else
                    {
                        obj.Age = Convert.ToInt32(iRow.GetCell(5, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue);
                    }
                    ICell cell3 = iRow.GetCell(6, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                    if (cell3.CellType == CellType.Numeric)
                    {
                        obj.CardNo = cell3.NumericCellValue.ToString();
                    }
                    else
                    {
                        obj.CardNo = iRow.GetCell(6, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    }
                    obj.Address = iRow.GetCell(7, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.SType = iRow.GetCell(8, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.AnQing = iRow.GetCell(9, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.GuanKong = iRow.GetCell(10, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.ActionType = iRow.GetCell(11, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    obj.StatusNow = iRow.GetCell(12, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    ICell cell4 = iRow.GetCell(13, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                    if (cell4.CellType == CellType.Numeric)
                    {
                        obj.PhoneNumber = cell4.NumericCellValue.ToString();
                    }
                    else
                    {
                        obj.PhoneNumber = iRow.GetCell(13, MissingCellPolicy.CREATE_NULL_AS_BLANK).StringCellValue;
                    }
                    var picture = from s in list
                                  where s.MinCol == 1
                                  where s.MinRow == i
                                  select s;
                    if (picture.FirstOrDefault() != null)
                    {
                        Image image = ByteToImage(picture.FirstOrDefault().PictureData);
                        obj.PicImage = new SerializeObjectToString().SerializeObject(image);
                    }
                    else
                    {
                        obj.PicImage = new SerializeObjectToString().SerializeObject(Properties.Resources.pic);
                    }
                    if (this.servicesInfo.ExstsId(result))
                    {
                        int re = servicesInfo.UpdtePersonInfoById(obj, result);
                        if (re == 1)
                        {
                            iRow.CreateCell(14, CellType.String).SetCellValue("更新信息成功！");
                        }
                        else
                        {
                            iRow.CreateCell(14, CellType.String).SetCellValue("更新信息失败！");
                        }
                    }
                    else
                    {
                        int re = servicesInfo.AddPersonInfo(obj);
                        if (re == 1)
                        {
                            iRow.CreateCell(14, CellType.String).SetCellValue("插入信息成功！");
                        }
                        else
                        {
                            iRow.CreateCell(14, CellType.String).SetCellValue("插入信息失败！");
                        }
                    }
                }
                catch (Exception)
                {
                    iRow.CreateCell(14, CellType.String).SetCellValue("插入或更新信息失败！");
                    continue;
                }
            }
            stream.Close();
            using (FileStream fs1 = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                wb.Write(fs1);
            }
            return "批量导入数据完成！可以去原Excel文件查看导入结果！";
        }
    }
}
