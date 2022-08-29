namespace FileIO {
	public static class FileIO {
		public static readonly XmlFileIoController xml = new XmlFileIoController();

		public static readonly BinarySerializationController binary = new BinarySerializationController();

		public static readonly XAttributeIoController xAttribute = new XAttributeIoController();

		public static readonly JsonFileIoController json = new JsonFileIoController();
	}
}
