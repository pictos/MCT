namespace CommunityToolkit.Maui.Core;

#pragma warning disable CA1063
partial class CameraManager
{
	const string notSupportedMessage = "CameraView is only supported on net-ios, net-android, net-windows and net-maccatalyst.";

	/// <summary>
	/// 
	/// </summary>
	/// <exception cref="NotSupportedException"></exception>
	public void Dispose() => throw new NotSupportedException(notSupportedMessage);
/// <summary>
/// 
/// </summary>
/// <returns></returns>
/// <exception cref="NotSupportedException"></exception>
	public NativePlatformCameraPreviewView CreatePlatformView() => throw new NotSupportedException(notSupportedMessage);

	public partial void UpdateFlashMode(CameraFlashMode flashMode) => throw new NotSupportedException(notSupportedMessage);

	public partial void UpdateIsTorchOn(bool isTorchOn) => throw new NotSupportedException(notSupportedMessage);

	public partial void UpdateZoom(float zoomLevel) => throw new NotSupportedException(notSupportedMessage);

	public partial ValueTask UpdateCaptureResolution(Size resolution, CancellationToken token) => throw new NotSupportedException(notSupportedMessage);

	protected virtual  partial Task PlatformStartVideoRecording(Stream stream, CancellationToken token) => throw new NotSupportedException(notSupportedMessage);
	protected virtual  partial Task<Stream> PlatformStopVideoRecording(CancellationToken token) => throw new NotSupportedException(notSupportedMessage);
	protected virtual  partial Task PlatformStartCameraPreview(CancellationToken token) => throw new NotSupportedException(notSupportedMessage);

	protected virtual  partial void PlatformStopCameraPreview() => throw new NotSupportedException(notSupportedMessage);

	protected virtual  partial Task PlatformConnectCamera(CancellationToken token) => throw new NotSupportedException(notSupportedMessage);

	protected virtual  partial void PlatformDisconnect() => throw new NotSupportedException(notSupportedMessage);

	protected virtual  partial ValueTask PlatformTakePicture(CancellationToken token) => throw new NotSupportedException(notSupportedMessage);
}