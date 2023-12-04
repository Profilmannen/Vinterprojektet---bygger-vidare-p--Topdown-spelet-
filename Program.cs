// See https://aka.ms/new-console-template for more information
using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "Hello");
Raylib.SetTargetFPS(60);

int x = 0;
Vector2 position = new Vector2(0, 0);

Vector2 movement = new Vector2(5, 5);

Color hotpink = new Color(255, 105, 180, 255);

Rectangle characterRect = new Rectangle(300, 400, 64, 64);

while (!Raylib.WindowShouldClose())
{
    // position += movement;

    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)){
        characterRect.x += movement.X;
        
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)){
        characterRect.x -= movement.X;
    }

    if(Raylib.IsKeyDown(KeyboardKey.KEY_UP)){
        characterRect.y -= movement.Y;
    }

    if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)){
        characterRect.y += movement.Y;
    }




    //characterRect.x += movement.X;
    //characterRect.y += movement.Y;



    // x++;
    Raylib.BeginDrawing();
    Raylib. ClearBackground(Color.GOLD);

    Raylib.DrawRectangle(10, 40, 300, 50, Color.BLACK);
    Raylib.DrawRectangleRec(characterRect, hotpink);
    Raylib.EndDrawing();
}