﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnClick(object sender, EventArgs e)
    {
        this.Time1.Text = System.DateTime.Now.ToString();
        this.Time2.Text = System.DateTime.Now.ToString();
    }


}