Shapes
======

An application that handles basic shapes.

Requirement
===========

Write an application that will be able to handle basic shapes.  The application will take as input a list of shapes, sizes, and colors.  The application will output a list of all the shapes sorted by area, then by color alphabetically.  The application will also output a list of all the shapes of a given type by area, then by color alphabetically.


The following shapes are allowed:  circle, rectangle, square, and triangle.


The following colors are allowed for shapes:  blue, green, red, purple, and yellow.


The following rules apply for the shapes:

 - For all shapes, you will be given a color.
 - For a circle, you will be given a radius.
 - For a rectangle you will be given a length and width.
 - For a square you will be given a length.
 - For a triangle you will be given a base and height.

Sample input:
```
triangle, 5, 6, yellow
square, 8, red
circle, 3, blue
triangle, 5, 6, green
rectangle, 10, 5, purple
```
Sample output for all shapes:
```
triangle, 15.00, green
triangle, 15.00, yellow
circle, 28.27, blue
rectangle, 50.00, purple
square, 64.00, purple
```
Sample output for triangles:
```
triangle, 15.00, green
triangle, 15.00, yellow
```

Some Notes From The Development Process
=======================================

Notes:

The comparer test is fairly opaque. It would be best to refactor this into a set of tests that more discretely test the comparer, but I chose this route for brevity.

The comparer does a case insensitive comparison of color names. This seemed like a reasonable design decision since colors are generally the same regardless of how we case them.

Generally converted doubles to decimals wherever possible to avoid floating point math (didn't think this program warranted the addition of epsilon comparisons, though that could be done.).

Generally decided against testing for empty colors and negative dimension lengths. These don't necessarily harm the application but are edge cases that could be added as specs later if desired.

There probably could have been some sort of inheritance relationship between rectangle and square, or between square and circle - rectangle and triangle.

The tests for some properties of each of the discrete shape classes is very repetative, which smells bad to me. It would be good to refactor things so that the tests could be written with much less repetition between each shape type.

The FillFromString method makes fairly ugly use of a switch. This isn't very extensible and might be a bit too procedural. If adding shape types to the API was a common occurance, I would refactor this to avoid the switch statement.

As it stands now the ShapeList class does not implicitly sort the shapes. The calling program must currently make a call to the ShapeList.Sort() method for the list to be sorted, but this works as specified.
