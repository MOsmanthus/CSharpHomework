using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{
    private string myId;

    public Shape(string s)
    {
        Id = s;
    }
    //类型
    public string Id
    {
        get
        {
            return myId;
        }
        set
        {
            myId = value;
        }
    }
    //面积，抽象属性
    public abstract double Area
    {
        get;
    }
    //绘制，虚方法
    public virtual void Draw()
    {
        Console.WriteLine("Draw Shape Icon");
    }
    //覆盖object的虚方法
    public override string ToString()
    {
        return Id + " Area = " + string.Format("{0 :F2}", Area);
    }
}

//三角形类
public class Triangle : Shape
{
    //三边长
    private int mySide1, mySide2, mySide3;

    public Triangle(int side1,int side2,int side3,string id) : base(id)
    {
        mySide1 = side1;
        mySide2 = side2;
        mySide3 = side3;
    }
    //实现面积
    public override double Area
    {
        get
        {
            double s = (mySide1 + mySide2 + mySide3) / 2;
            return Math.Sqrt(s * (s - mySide1) * (s - mySide2) * (s - mySide3));
        }
    }
    //覆盖绘制方法
    public override void Draw()
    {
        Console.WriteLine("Draw Triangle: " + mySide1 + " " + mySide2 + " " + mySide3);
    }
}

//圆类
public class Circle : Shape
{
    //边长
    private int myRadius;

    public Circle(int radius, string id) : base(id)
    {
        myRadius = radius;
    }
    //实现面积
    public override double Area
    {
        get
        {
            return myRadius * myRadius * System.Math.PI;
        }
    }
    //覆盖绘制方法
    public override void Draw()
    {
        Console.WriteLine("Draw Circle: " + myRadius);
    }
}

//正方形类
public class Square : Shape
{
    //边长
    private int mySide;

    public Square(int side,string id) : base(id)
    {
        mySide = side;
    }
    //实现面积
    public override double Area
    {
        get
        {
            return mySide * mySide;
        }
    }
    //覆盖绘制方法
    public override void Draw()
    {
        Console.WriteLine("Draw Square: " + mySide);
    }
}

//长方形类
public class Rectangle : Shape
{
    //边长
    private int myWidth, myHeight;

    public Rectangle(int width, int height, string id) : base(id)
    {
        myWidth = width;
        myHeight = height;
    }
    //实现面积
    public override double Area
    {
        get
        {
            return myWidth * myHeight;
        }
    }
    //覆盖绘制方法
    public override void Draw()
    {
        Console.WriteLine("Draw Rectangle: " + myWidth + myHeight);
    }
}

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(3,4,5,"Triangle"),
                new Circle(6,"Circle"),
                new Square(3,"Square"),
                new Rectangle(4,5,"Rectangle")
            };

            System.Console.WriteLine("Shapes Collection");
            foreach(Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
