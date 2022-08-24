# ModBuilderLMR
How To Create LMR Mod

Качай Unity, создавай проект с именем твоего мода, помещай в папку Assets все необходимые файлы (распределяй по папкам ровно так же, как это сделано в самой игре), В верхнем меню Mods -> Build Mod. Всё упакуется в файл имя_проекта.mod в папке Mods директории проекта

P.S. В файле **ModBuilder.cs** поменяй строку 
```c# 
/*14*/ string modPath = @"ПОЛНЫЙ ПУТЬ ДО ИГРЫ";
```
на свой путь до игры. Пример: ```E:\SteamLibrary\steamapps\common\Love, Money, Rock-n-Roll```