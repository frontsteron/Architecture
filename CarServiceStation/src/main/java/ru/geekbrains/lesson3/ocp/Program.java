package ru.geekbrains.lesson3.ocp;

import java.util.ArrayList;
import java.util.Collection;

public class Program {

    public static void main(String[] args) {


        Collection<Shape> shapes = new ArrayList<>();
        shapes.add(new RightTriangle(2, 3));
        shapes.add(new Square(4));

        ShapeService shapeService = new ShapeService();
        shapeService.processShapes(shapes);

    }
}
