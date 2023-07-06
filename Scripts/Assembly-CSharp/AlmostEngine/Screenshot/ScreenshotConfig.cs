using System;
using System.Collections.Generic;
using UnityEngine;
using AlmostEngine;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class ScreenshotConfig
	{
		public enum AntiAliasing
		{
			NONE = 0,
			TWO = 2,
			FOUR = 4,
			EIGHT = 8,
		}

		public enum ShotMode
		{
			ONE_SHOT = 0,
			BURST = 1,
		}

		public enum CamerasMode
		{
			GAME_VIEW = 0,
			CUSTOM_CAMERAS = 1,
		}

		public enum ResolutionMode
		{
			GAME_VIEW = 0,
			CUSTOM_RESOLUTIONS = 1,
		}

		public enum CompositionMode
		{
			SIMPLE_CAPTURE = 0,
			COMPOSITION = 1,
		}

		public enum BatchMode
		{
			SIMPLE_CAPTURE = 0,
			BATCHES = 1,
		}

		public ScreenshotNameParser.DestinationFolder m_DestinationFolder;
		public string m_RelativePath;
		public string m_RootedPath;
		public string m_FileName;
		public bool m_OverrideFiles;
		public TextureExporter.ImageFileFormat m_FileFormat;
		public float m_JPGQuality;
		public ScreenshotTaker.CaptureMode m_CaptureMode;
		public AntiAliasing m_MultisamplingAntiAliasing;
		public ScreenshotTaker.ColorFormat m_ColorFormat;
		public bool m_RecomputeAlphaLayer;
		public ShotMode m_ShotMode;
		public int m_MaxBurstShotsNumber;
		public float m_ShotTimeStep;
		public CamerasMode m_CameraMode;
		public bool m_ExportToDifferentLayers;
		public List<ScreenshotCamera> m_Cameras;
		public ResolutionMode m_ResolutionCaptureMode;
		public List<ScreenshotResolution> m_Resolutions;
		public ScreenshotResolution m_GameViewResolution;
		public bool m_CaptureActiveUICanvas;
		public List<ScreenshotOverlay> m_Overlays;
		public CompositionMode m_CompositionMode;
		public List<ScreenshotComposer> m_Composers;
		public BatchMode m_BatchMode;
		public List<ScreenshotBatch> m_Batches;
		public bool m_ShowGuidesInPreview;
		public Canvas m_GuideCanvas;
		public Color m_GuidesColor;
		public bool m_ShowPreview;
		public float m_PreviewSize;
		public bool m_PreviewInGameViewWhilePlaying;
		public bool m_StopTimeOnCapture;
		public bool m_PlaySoundOnCapture;
		public AudioClip m_ShotSound;
		public HotKey m_CaptureHotkey;
		public HotKey m_UpdatePreviewHotkey;
		public HotKey m_AlignHotkey;
		public HotKey m_PauseHotkey;
		public ScreenshotTaker.GameViewResizingWaitingMode m_GameViewResizingWaitingMode;
		public float m_ResizingWaitingTime;
		public int m_ResizingWaitingFrames;
		public bool m_ShowDestination;
		public bool m_ShowName;
		public bool m_ShowCaptureMode;
		public bool m_ShowResolutions;
		public bool m_ShowCameras;
		public bool m_ShowCanvas;
		public bool m_ShowComposition;
		public bool m_ShowBatches;
		public bool m_ShowPreviewGUI;
		public bool m_ShowCapture;
		public bool m_ShowHotkeys;
		public bool m_ShowGallery;
		public bool m_ShowUtils;
		public bool m_ShowUsage;
		public bool m_ShowDelay;
	}
}
