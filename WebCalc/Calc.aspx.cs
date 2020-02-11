using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calc : System.Web.UI.Page
{
    MathLib lib;
    protected void Page_Load(object sender, EventArgs e)
    {
        lib = new MathLib();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label5.Text = "";
        if (!TextBox1.Text.Equals("") && !TextBox5.Text.Equals(""))
        {
            try
            {
                TextBox9.Text = lib.Add(int.Parse(TextBox1.Text), int.Parse(TextBox5.Text)).ToString();
            }
            catch (Exception)
            {
                Label5.Text = "Enter correct values in both fields!";
            }
        }
        else
        {
            Label5.Text = "Enter correct values in both fields!";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label5.Text = "";
        if (!TextBox2.Text.Equals("") && !TextBox6.Text.Equals(""))
        {
            try
            {
                TextBox10.Text = lib.Subtract(int.Parse(TextBox2.Text), int.Parse(TextBox6.Text)).ToString();
            }
            catch (Exception)
            {
                Label5.Text = "Enter correct values in both fields!";
            }
        }
        else
        {
            Label5.Text = "Enter correct values in both fields!";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label5.Text = "";
        if (!TextBox3.Text.Equals("") && !TextBox7.Text.Equals(""))
        {
            try
            {
                TextBox11.Text = lib.Mult(double.Parse(TextBox3.Text), double.Parse(TextBox7.Text)).ToString();
            }
            catch (Exception)
            {
                Label5.Text = "Enter correct values in both fields!";
            }
        }
        else
        {
            Label5.Text = "Enter correct values in both fields!";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Label5.Text = "";
        if (!TextBox4.Text.Equals("") && !TextBox8.Text.Equals(""))
        {
            try
            {
                TextBox12.Text = lib.Div(double.Parse(TextBox4.Text), double.Parse(TextBox8.Text)).ToString();
            }
            catch (Exception)
            {
                Label5.Text = "Enter correct values in both fields!";
            }
        }
        else
        {
            Label5.Text = "Enter correct values in both fields!";
        }
    }
}