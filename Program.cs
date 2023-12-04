// See https://aka.ms/new-console-template for more information
using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "Hello");
Raylib.SetTargetFPS(60);

int x = 0;
Vector2 position = new Vector2(0, 0);

Vector2 movement = new Vector2(5, 5);

Color red = new Color(255, 0, 0, 255);

Rectangle playerRect = new Rectangle(300, 400, 64, 64);
Rectangle enemyRect = new Rectangle (200, 200, 64, 64);

Rectangle overlap = Raylib.GetCollisionRec(playerRect, enemyRect);
while (!Raylib.WindowShouldClose())
{
    // position += movement;

    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)){
        playerRect.x += movement.X;
        
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)){
        playerRect.x -= movement.X;
    }

    if(Raylib.IsKeyDown(KeyboardKey.KEY_UP)){
        playerRect.y -= movement.Y;
    }

    if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)){
        playerRect.y += movement.Y;
    }




    //characterRect.x += movement.X;
    //characterRect.y += movement.Y;



    // x++;
    Raylib.BeginDrawing();
    Raylib. ClearBackground(Color.GOLD);

    
    Raylib.DrawRectangleRec(playerRect, red);
    Raylib.DrawRectangleRec(enemyRect, Color.BLACK);
    Raylib.DrawRectangleRec(overlap, Color.ORANGE);
    
    Raylib.EndDrawing();

}