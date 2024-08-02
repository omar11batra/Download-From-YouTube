# YouTube Video Downloader

This C# application is designed to download videos from YouTube, providing users with the ability to save their favorite videos locally. It's useful for offline viewing, archiving, or converting videos for use in other projects.

## Features

- Supports downloading videos in various formats and qualities.
- Allows users to extract audio from videos.
- Simple command-line interface for easy use.
- Batch downloading capability for multiple videos.

## Requirements

- .NET Framework (or .NET Core/5/6+ if applicable)
- Visual Studio or any C# IDE for development and compilation
- Internet connection

## Installation

To set up and run the project, follow these steps:

1. **Clone the repository:**
   ```sh
   git clone https://github.com/omar11batra/Download-From-YouTube.git
   ```

2. Open the project:

   Open the .sln file in Visual Studio or your preferred C# IDE.

   3. Build the project:
  
      Build the solution to restore dependencies and compile the application.


      ## Usage

      After building the project, you can run the executable from the command line to download videos from YouTube.


      ## Command-Line Arguments

      video_url: URL of the YouTube video to download.
      
output_path: Path where the downloaded video should be saved.

format: (Optional) Desired format for the video (e.g., mp4, mp3).

quality: (Optional) Desired quality (e.g., 720p, 1080p).

## Example

```sh
   YouTubeDownloader.exe https://www.youtube.com/watch?v=example_video output.mp4 1080p
   YouTubeDownloader.exe urls.txt output_directory
   YouTubeDownloader.exe videos.txt C:\DownloadedVideos
   Replace placeholders like `https://github.com/omar11batra/Download-From-YouTube.git`, `omar11batra`, and `aburad211@gmail.com` with your actual GitHub username and contact information. Customize any additional details specific to your project.
   ```
