module Cake.SquareLogo.Tests.Logo

open Cake.SquareLogo.Main
open System.Drawing
open NUnit.Framework
open FluentAssertions

[<Test>]
let shouldAdd()  = (1 + 1).Should().Be(2, "") |> ignore

[<Test>]
let shouldCreateLogo() =
      let family = new FontFamily("Monaco")
      let font = new Font(family, 40.0f , FontStyle.Regular, GraphicsUnit.Pixel)

      let settings = 
            { FontFamily = "American Typewriter"
              FontSize = 40.0f
              Foreground = "White"
              Background = "DimGray" }

      drawText("C#", "Screen/csharp.png", settings)
      drawText("F#", "Screen/fsharp.png", settings)
      drawText("XA", "Screen/xamarin.png", settings)
      drawText("NG", "Screen/angular.png", settings)
      drawText("KT", "Screen/kotlin.png", settings)
      drawText("VS", "Screen/visual-studio.png", settings)
      drawText("RN", "Screen/roslyn.png", settings)
      drawText("CK", "Screen/cake.png", settings)

