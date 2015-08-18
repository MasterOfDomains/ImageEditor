using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace ImageEditor.Editing
{
    public class CropProfile
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DisplayName("Profile Name")]
        [StringLength(64)]
        [Required(ErrorMessage = "Profile Name is required")]
        public string Name { get; set; }
        [DisplayName("Default Width")]
        [Required(ErrorMessage = "Width is required")]
        public int Width { get; set; }
        [DisplayName("Default Height")]
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }
        [DisplayName("Crop Color")]
        [Required(ErrorMessage = "Color is required")]
        public int CropColor { get; set; }
        [DisplayName("Default Image Directory")]
        [Required(ErrorMessage = "Default Directory is required")]
        public string ImageDirectory { get; set; }

#if XML_DATA_PERSISTENCE
        public bool CreateProfileTable()
        {
            bool success = true;
            string baseDir = System.AppDomain.CurrentDomain.BaseDirectory;

            try
            {
                var writer = new XmlTextWriter(baseDir, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                writer.WriteStartElement("TableName");

                writer.WriteStartElement("ColumnName");
                writer.WriteString(string.Empty);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch
            {
                success = false;
            }

            return success;
        }
#endif
        /*
Private Function CreateEmptyTable(ByVal TableName As String, _
	ByVal ParamArray ColumnNames() As String) As Boolean
  Dim writer As New XmlTextWriter(filePath, System.Text.Encoding.UTF8)

  Try
    writer.WriteStartDocument(True)
    writer.Formatting = Formatting.Indented
    writer.Indentation = 2
    writer.WriteStartElement("Table")
    writer.WriteStartElement(TableName)
    For Each ColumnName As String In ColumnNames
      writer.WriteStartElement(ColumnName)
      writer.WriteString(String.Empty)
      writer.WriteEndElement()
    Next
    writer.WriteEndElement()
    writer.WriteEndElement()
    writer.WriteEndDocument()
    writer.Close()
  Catch ex As Exception
    MsgBox("Cannot create new table.")
    Return False
  End Try

  Return True
End Function
         * */

        public CropProfile Copy()
        {
            return (CropProfile)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Profile Name: " + Name + ", " +
                "Width: " + Width + ", " +
                "Height: " + Height + ", " +
                "Color: " + CropColor + ", " +
                "Dir: " + ImageDirectory;
        }
    }
}