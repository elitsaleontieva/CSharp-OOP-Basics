using System;
using System.Collections.Generic;
using System.Text;


    public class Box
    {
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public override string ToString()
    {
        return $"Surface Area - {(2 * (this.length * this.width) + (2 * (this.length * this.height))) + (2 * (this.width * this.height)):F2}" +
               $"{Environment.NewLine}" +
               $"Lateral Surface Area - {(2 * (this.length * this.height)) + (2 * (this.width * this.height)):F2}" +
               $"{Environment.NewLine}" +
               $"Volume - {this.length * this.width * this.height:F2}";
            


    }
}

