
namespace SquareLogo

open System.Runtime.CompilerServices
open SquareLogo.Drawing

type LogoSettings() =
      member val FontFamily = "Optima" with set,get
      member val FontSize = 45.0f with set,get
      member val Foreground = "White" with set,get
      member val Background = "DimGray" with set,get
      member val Padding = 20.0f with set,get
      member val NoSquare = false with set,get

type Logo() =
      member __.CreateLogo(text: string, outputPath: string, settings: LogoSettings) =
            let settings =
                { DrawSettings.FontSize =  settings.FontSize
                  FontFamily = settings.FontFamily
                  Foreground = settings.Foreground
                  Padding = settings.Padding
                  NoSquare = settings.NoSquare
                  Background = settings.Background }
            drawText(text, outputPath, settings)

      member __.CreateLogo(text: string, outputPath: string) =
            let settings = LogoSettings()
            __.CreateLogo(text, outputPath, settings)