﻿/*
 * Created by SharpDevelop.
 * User: Xyrus
 * Date: 3/26/2016
 * Time: 7:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChessBridge
{
    /// <summary>
    /// Description of MaterialPropertiesPanel.
    /// </summary>
    public partial class MaterialPropertiesPanel : UserControl
    {
        public MaterialPropertiesPanel()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
        public void setPersonality(Personality personality)
        {
            //init control values
            this.qSlider.Value = personality.OwnQ;
            this.qSpinner.Value = personality.OwnQ;
            this.QVal.Text = (double.Parse(personality.OwnQ.ToString()) / 10.00).ToString("0.0");

            this.oppQSlider.Value = personality.OppQ;
            this.oppQSpinner.Value = personality.OppQ;
            this.oppQVal.Text = (double.Parse(personality.OppQ.ToString()) / 10.00).ToString("0.0");

            this.rSlider.Value = personality.OwnR;
            this.rSpinner.Value = personality.OwnR;
            this.RVal.Text = (double.Parse(personality.OwnR.ToString()) / 10.00).ToString("0.0");

            this.oppRSlider.Value = personality.OppR;
            this.oppRSpinner.Value = personality.OppR;
            this.oppRVal.Text = (double.Parse(personality.OwnR.ToString()) / 10.00).ToString("0.0");

            this.bSlider.Value = personality.OwnB;
            this.bSpinner.Value = personality.OwnB;
            this.BVal.Text = (double.Parse(personality.OwnB.ToString()) / 10.00).ToString("0.0");

            this.oppBSlider.Value = personality.OppB;
            this.oppBSpinner.Value = personality.OppB;
            this.oppBVal.Text = (double.Parse(personality.OppB.ToString()) / 10.00).ToString("0.0");

            this.nSlider.Value = personality.OwnN;
            this.nSpinner.Value = personality.OwnN;
            this.NVal.Text = (double.Parse(personality.OwnN.ToString()) / 10.00).ToString("0.0");

            this.oppNSlider.Value = personality.OppN;
            this.oppNSpinner.Value = personality.OppN;
            this.oppNVal.Text = (double.Parse(personality.OppN.ToString()) / 10.00).ToString("0.0");

            this.pSlider.Value = personality.OwnP;
            this.pSpinner.Value = personality.OwnP;
            this.PVal.Text = (double.Parse(personality.OwnP.ToString()) / 10.00).ToString("0.0");

            this.oppPSlider.Value = personality.OppP;
            this.oppPSpinner.Value = personality.OppP;
            this.oppPVal.Text = (double.Parse(personality.OppP.ToString()) / 10.00).ToString("0.0");
        }
        
         /**
         * Writes current values to the specified personality.
         */ 
        public void saveToPersonality(Personality personality)
        {
            personality.OwnQ = this.qSlider.Value;
            personality.OwnQ = (int)this.qSpinner.Value;
            
            personality.OppQ = this.oppQSlider.Value;
            personality.OppQ = (int)this.oppQSpinner.Value;
            
            personality.OwnR = this.rSlider.Value;
            personality.OwnR = (int)this.rSpinner.Value;
            
            personality.OppR = this.oppRSlider.Value;
            personality.OppR = (int)this.oppRSpinner.Value;
            
            personality.OwnB = this.bSlider.Value;
            personality.OwnB = (int)this.bSpinner.Value;
            
            personality.OppB = this.oppBSlider.Value;
            personality.OppB = (int)this.oppBSpinner.Value;
            
            personality.OwnQ = this.nSlider.Value;
            personality.OwnQ = (int)this.nSpinner.Value;
            
            personality.OppN = this.oppNSlider.Value;
            personality.OppN = (int)this.oppNSpinner.Value;
            
            personality.OwnP = this.pSlider.Value;
            personality.OwnP = (int)this.pSpinner.Value;
            
            personality.OppP = this.oppPSlider.Value;
            personality.OppP = (int)this.oppPSpinner.Value;
        }
        
        void QSliderScroll(object sender, EventArgs e)
        {
            int slider = this.qSlider.Value;
            int spinner = (int)this.qSpinner.Value;
            if (slider != spinner)
            {
                this.qSpinner.Value = this.qSlider.Value;
                this.QVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void QSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.qSlider.Value;
            int spinner = (int)this.qSpinner.Value;
            if (slider != spinner)
            {
                this.qSlider.Value = (int)this.qSpinner.Value;
            }
        }
        
        void OppQSliderScroll(object sender, EventArgs e)
        {
            int slider = this.oppQSlider.Value;
            int spinner = (int)this.oppQSpinner.Value;
            if (slider != spinner)
            {
                this.oppQSpinner.Value = this.oppQSlider.Value;
                this.oppQVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void OppQSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.oppQSlider.Value;
            int spinner = (int)this.oppQSpinner.Value;
            if (slider != spinner)
            {
                this.oppQSlider.Value = (int)this.oppQSpinner.Value;
            }
        }
        
        void RSliderScroll(object sender, EventArgs e)
        {
            int slider = this.rSlider.Value;
            int spinner = (int)this.rSpinner.Value;
            if (slider != spinner)
            {
                this.rSpinner.Value = this.rSlider.Value;
                this.RVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void RSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.rSlider.Value;
            int spinner = (int)this.rSpinner.Value;
            if (slider != spinner)
            {
                this.rSlider.Value = (int)this.rSpinner.Value;
            }
        }
        
        void OppRSliderScroll(object sender, EventArgs e)
        {
            int slider = this.oppRSlider.Value;
            int spinner = (int)this.oppRSpinner.Value;
            if (slider != spinner)
            {
                this.oppRSpinner.Value = this.oppRSlider.Value;
                this.oppRVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void OppRSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.oppRSlider.Value;
            int spinner = (int)this.oppRSpinner.Value;
            if (slider != spinner)
            {
                this.oppRSlider.Value = (int)this.oppRSpinner.Value;
            }
        }
        
        void BSliderScroll(object sender, EventArgs e)
        {
            int slider = this.bSlider.Value;
            int spinner = (int)this.bSpinner.Value;
            if (slider != spinner)
            {
                this.bSpinner.Value = this.bSlider.Value;
                this.BVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void BSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.bSlider.Value;
            int spinner = (int)this.bSpinner.Value;
            if (slider != spinner)
            {
                this.bSlider.Value = (int)this.bSpinner.Value;
            }
        }
        
        void OppBSliderScroll(object sender, EventArgs e)
        {
            int slider = this.oppBSlider.Value;
            int spinner = (int)this.oppBSpinner.Value;
            if (slider != spinner)
            {
                this.oppBSpinner.Value = this.oppBSlider.Value;
                this.oppBVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void OppBSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.oppBSlider.Value;
            int spinner = (int)this.oppBSpinner.Value;
            if (slider != spinner)
            {
                this.oppBSlider.Value = (int)this.oppBSpinner.Value;
            }
        }
        
        void NSliderScroll(object sender, EventArgs e)
        {
            int slider = this.nSlider.Value;
            int spinner = (int)this.nSpinner.Value;
            if (slider != spinner)
            {
                this.nSpinner.Value = this.nSlider.Value;
                this.NVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void NSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.nSlider.Value;
            int spinner = (int)this.nSpinner.Value;
            if (slider != spinner)
            {
                this.nSlider.Value = (int)this.nSpinner.Value;
            }
        }
        
        void OppNSliderScroll(object sender, EventArgs e)
        {
            int slider = this.oppNSlider.Value;
            int spinner = (int)this.oppNSpinner.Value;
            if (slider != spinner)
            {
                this.oppNSpinner.Value = this.oppNSlider.Value;
                this.oppNVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void OppNSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.oppNSlider.Value;
            int spinner = (int)this.oppNSpinner.Value;
            if (slider != spinner)
            {
                this.oppNSlider.Value = (int)this.oppNSpinner.Value;
            }
        }
        
        void PSliderScroll(object sender, EventArgs e)
        {
            int slider = this.pSlider.Value;
            int spinner = (int)this.pSpinner.Value;
            if (slider != spinner)
            {
                this.pSpinner.Value = this.pSlider.Value;
                this.PVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void PSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.pSlider.Value;
            int spinner = (int)this.pSpinner.Value;
            if (slider != spinner)
            {
                this.pSlider.Value = (int)this.pSpinner.Value;
            }
        }
        
        void OppPSliderScroll(object sender, EventArgs e)
        {
            int slider = this.oppPSlider.Value;
            int spinner = (int)this.oppPSpinner.Value;
            if (slider != spinner)
            {
                this.oppPSpinner.Value = this.oppPSlider.Value;
                this.oppPVal.Text = (double.Parse(slider.ToString()) / 10.00).ToString("0.0");
            }
        }
        
        void OppPSpinnerValueChanged(object sender, EventArgs e)
        {
            int slider = this.oppPSlider.Value;
            int spinner = (int)this.oppPSpinner.Value;
            if (slider != spinner)
            {
                this.oppPSlider.Value = (int)this.oppPSpinner.Value;
            }
        }
    }
   
}
