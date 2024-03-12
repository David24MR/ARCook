# Cocina en realidad aumentada con HoloLens 2

Este proyecto es una aplicación de realidad aumentada desarrollada para HoloLens 2 que tiene como objetivo acompañar e ilustrar interactivamente el proceso de preparación de diversas recetas de comida. La aplicación permite a los usuarios ver los ingredientes y los pasos de las recetas en realidad aumentada mientras preparan la comida, lo que les brinda una experiencia inmersiva y práctica en la cocina.

## Características
- Interfaz Intuitiva: La aplicación cuenta con una interfaz fácil de usar diseñada específicamente para HoloLens 2, lo que permite a los usuarios navegar de manera intuitiva por las recetas y los pasos de preparación.
- Visualización de Ingredientes y Pasos: Los usuarios pueden ver los ingredientes necesarios para cada receta en realidad aumentada, así como los pasos detallados para preparar la comida, lo que facilita el seguimiento del proceso de cocina.
- Manos Libres: Al utilizar la realidad aumentada, los usuarios pueden tener las manos libres mientras cocinan, lo que les permite seguir las instrucciones sin tener que detenerse para consultar una receta impresa o un dispositivo móvil.

## Instalación
1. Clonar el repositorio en tu máquina local:
```git clone https://github.com/David24MR/ARCook.git```
2. Abrir el proyecto en Unity (Es necesario contar con el módulo Universal Windows Platform **UWP** dentro de Unity).
3. Construir la aplicación UWP para una arquitectura ARM64
4. Al terminar la contrucción, abrir la solución .sln con Visual Studio 2022 (Es necesario contar con todos los requerimientos para desplegar en HoloLens*)
5. Desplegar la aplicación en modo Release, para una arquitectura ARM64, utilizando la dirección IP de las HoloLens 2.
   
*Como el proyecto fue realizado utilizando MRTK3, es necesario contar con las instalaciones previas necesarias tanto en Unity, como en Visual Studio.

Documentación oficial: https://learn.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/mrtk3-overview/getting-started/overview

## Uso
1. Colocar tus HoloLens 2 y abrir la aplicación ARCook.
2. Seleccionar una categoría de comidas para cocinar.
3. Elegir una de las recetas disponibles dentro de esta categoría.
4. Asegurar de tener todos los ingredientes necesarios antes de iniciar.
5. Seguir los pasos y las instrucciones en realidad aumentada mientras cocinas.
6. Disfrutar de la comida!


## Créditos
Este proyecto fue desarrollado por Juan David Macias Rodriguez, bajo la supervisión y apoyo de Julián Camilo Mora Valbuena.
