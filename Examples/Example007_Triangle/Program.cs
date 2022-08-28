Console.Clear();
//Максимальное число итераций
int MAX_LENGTH_OF_POINTS = 1000;

//Треугольник как одномерный массив из массивов интов
int[][] triangle = new int[3][];
//определяем координаты точек треугольника
triangle[0] = new int[] { 30, 1 }; //координата первой точки
triangle[1] = new int[] { 1, 25 }; //координата второй точки
triangle[2] = new int[] { 60, 25 }; //координата третьей точки
drawPoint(triangle[0]);
drawPoint(triangle[1]);
drawPoint(triangle[2]);

//Определяем 2 случайные точки треугольника
int numberOfFirstPoint = new Random().Next(0, 3);
int numberOfSecondPoint = numberOfFirstPoint;
do numberOfSecondPoint = new Random().Next(0, 3);
while (numberOfSecondPoint == numberOfFirstPoint);

//Делаем массив всех точек, чтобы можно было выбрать из них случайную
int[][] points = new int[MAX_LENGTH_OF_POINTS][];
//заносим в него точки треугольника
points[0] = triangle[0];
points[1] = triangle[1];
points[2] = triangle[2];

//вычисляем первую серединную точку
int[] lastPoint = calculateMiddlePoint(triangle[numberOfFirstPoint], triangle[numberOfSecondPoint]);



/*for (int i = 0; i < 100; i++)
{
    //заносим последнюю точку в массив со всеми точками
    points[i+3] = lastPoint;
    //рисуем последнюю точку
    drawPoint(lastPoint);
    //номер случайной точки среди всех, кроме последней
    int numberOfRandomPoint = new Random().Next(0, i+3);
    //вычисляем новую серединную точку из предыдущей серединной и случайной
    lastPoint = calculateMiddlePoint(points[numberOfRandomPoint], lastPoint);
}*/

for (int i = 0; i < 1000; i++)
{
    //рисуем последнюю точку
    drawPoint(lastPoint);
    //номер случайной точки среди точек треугольника
    int numberOfRandomPoint = new Random().Next(0, 3);
    //вычисляем новую серединную точку из предыдущей серединной и случайной точки треугольника
    lastPoint = calculateMiddlePoint(triangle[numberOfRandomPoint], lastPoint);
}

void drawPoint(int[] coordinates)
{
    Console.SetCursorPosition(coordinates[0], coordinates[1]);
    Console.Write('+');
}

int[] calculateMiddlePoint(int[] point1, int[] point2)
{
    int[] middlePoint = new int[2];
    middlePoint[0] = (point1[0] + point2[0]) / 2;
    middlePoint[1] = (point1[1] + point2[1]) / 2;
    return middlePoint;
}