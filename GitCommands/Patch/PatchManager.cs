            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, out var header);
        public static byte[] GetSelectedLinesAsPatch(string text, int selectionPosition, int selectionLength, bool staged, Encoding fileContentEncoding, bool isNewFile)
            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, out var header);
            string[] headerLines = header.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            const string fileMode = "100000"; // given fake mode to satisfy patch format, git will override this
            var s = new StringBuilder();
            byte[] bs = Encoding.UTF8.GetBytes(input);
        public List<PatchLine> PreContext { get; } = new List<PatchLine>();
        public List<PatchLine> RemovedLines { get; } = new List<PatchLine>();
        public List<PatchLine> AddedLines { get; } = new List<PatchLine>();
        public List<PatchLine> PostContext { get; } = new List<PatchLine>();
        public string WasNoNewLineAtTheEnd { get; set; }
        public string IsNoNewLineAtTheEnd { get; set; }
        private readonly List<SubChunk> _subChunks = new List<SubChunk>();
        private SubChunk _currentSubChunk;
            string[] lines = fileText.Split(new[] { eol }, StringSplitOptions.None);
        public static ChunkList GetSelectedChunks(string text, int selectionPosition, int selectionLength, out string header)
            string[] chunks = diff.Split(new[] { "\n@@" }, StringSplitOptions.RemoveEmptyEntries);