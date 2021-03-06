﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ASPxperience_UploadControl_CallbackData : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        string fileName = e.UploadedFile.FileName;
        
       
        // save file to disk or database
        // string fullFileName = MapPath(uploadFolder) + fileName;
        // ASPxUploadControl1.SaveAs(fullFileName);
        e.CallbackData = fileName;
    }

    protected void ASPxUploadControl2_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        string fileName = e.UploadedFile.FileName;
        e.CallbackData = fileName;
    }
}
