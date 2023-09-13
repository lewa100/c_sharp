using System;
using static System.Console;

// y = k1 * x + b1
// y = k2 * x + b2 

// k2 * x + b2 = k1 * x + b1
// k2 * x - k1 * x = b1 - b2
// x * ( k2 - k1 ) = b1 - b2
// x = (b1 - b2) / ( k2 - k1 )
// y = k1 * x + b1 
class Line {
    private int id;
    public double constant;
    public double coefficient;

    public Line(int numLine){
        id = numLine;
        inputParams();
    }

    public void inputParams(){
        WriteLine($"Введите константу для линии {id}:");
        constant = Convert.ToDouble(ReadLine());
        WriteLine($"Введите коэффициент для линии {id}:");
        coefficient = Convert.ToDouble(ReadLine());
    }

    public void print(){
        WriteLine($"Лмния №:\t{id}");
        WriteLine($"Коэффициент:\t{constant}");
        WriteLine($"Константа:\t{coefficient}");
    }
}

class Program
{
    static double[] getPoint(Line l1, Line l2){
        double[] point = new double[2];
        // x = (b1 - b2) / ( k2 - k1 )
        point[0] = (l1.constant - l2.constant) / (l2.coefficient - l1.coefficient);
        // y = k1 * x + b1
        point[1] = l1.coefficient*point[0]+l1.constant;
        return point;
    }


    static void Main(string[] args){
        Line line1 = new Line(1);
        Line line2 = new Line(2);
        line1.print();
        line2.print();

        double[] point = getPoint(line1,line2);
        WriteLine($"Точка пересечения:({point[0]},{point[1]})");
    }
}
