﻿using System;

namespace Lab4
{
    public abstract class Shape
    {
        private double _width;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1;
                }
            }

        }
        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }
		
        private readonly string _color = "gold";
        public string Color
        {
            get { return _color; }
            //set { _color = "gold"; }
        }
        
        public Shape(string color)
        {
            _color = color;
        }

       
        public abstract double getArea();
        public abstract double getPerimeter();

         public override string ToString()
        {
            return "";
        }
 
        }
        
    }


