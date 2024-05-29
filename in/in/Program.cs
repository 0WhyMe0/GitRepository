void GetRectangleData(ref int width, ref int height, out int rectArea, out int rectPerimetr)
{   
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

int w = 10;
int h = 20;
GetRectangleData(ref w, ref h, out var area, out var perimetr);

Console.WriteLine($"Площадь прямоугольника: {area}");       
Console.WriteLine($"Периметр прямоугольника: {perimetr}");