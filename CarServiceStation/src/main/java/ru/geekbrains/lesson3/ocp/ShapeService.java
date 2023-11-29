package ru.geekbrains.lesson3.ocp;

import java.util.Collection;

public class ShapeService {

    public void processShapes(Collection<Shape> shapes){

        double sumArea = 0;

        for (Shape shape: shapes) {

            sumArea += shape.getArea();
            /*if (shape instanceof Square){
                sumArea += Math.pow(((Square)shape).getSide(), 2);
            }
            else if (shape instanceof RightTriangle){
                sumArea += ((RightTriangle)shape).getKatet1() * ((RightTriangle)shape).getKatet2() / 2.0;
            }*/
        }

        System.out.printf("Сумма площадей фигур равна %f \n", sumArea);

    }

}
