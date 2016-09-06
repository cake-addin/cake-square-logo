
module Cake.SquareLogo.LogoAlias

open Cake.Core
open Cake.Core.Annotations
open Cake.SquareLogo.Main

type LogoSettings() =
      member val FontFamily = "Optima" with set,get
      member val FontSize = 45.0f with set,get
      member val Foreground = "White" with set,get
      member val Background = "DimGray" with set,get

type ICakeContext with
      
      [<CakeMethodAlias>]
      member this.CreateLogo(text: string, outputPath: string) =
            let settings = LogoSettings()
            this.CreateLogo(text, outputPath, settings)

      [<CakeMethodAlias>]
      member this.CreateLogo(text: string, outputPath: string, settings: LogoSettings) =
            let settings =  
                { DrawSettings.FontSize =  settings.FontSize
                  FontFamily = settings.FontFamily
                  Foreground = settings.Foreground
                  Background = settings.Background }
            drawText(text, outputPath, settings)


