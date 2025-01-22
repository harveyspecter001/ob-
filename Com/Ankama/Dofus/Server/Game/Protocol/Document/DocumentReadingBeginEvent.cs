using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Document
{
	// Token: 0x020007DB RID: 2011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DocumentReadingBeginEvent : IMessage<DocumentReadingBeginEvent>, IMessage, IEquatable<DocumentReadingBeginEvent>, IDeepCloneable<DocumentReadingBeginEvent>, IBufferMessage
	{
		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x00222A9C File Offset: 0x00220C9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DocumentReadingBeginEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x00222AAC File Offset: 0x00220CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x00222ABC File Offset: 0x00220CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x00222ACC File Offset: 0x00220CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DocumentReadingBeginEvent()
		{
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x00222ADC File Offset: 0x00220CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DocumentReadingBeginEvent(DocumentReadingBeginEvent other)
		{
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x00222AEC File Offset: 0x00220CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DocumentReadingBeginEvent Clone()
		{
			return null;
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x00222AFC File Offset: 0x00220CFC
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x00222B0C File Offset: 0x00220D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DocumentId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x00222B1C File Offset: 0x00220D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x00222B2C File Offset: 0x00220D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DocumentReadingBeginEvent other)
		{
			return true;
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00222B3C File Offset: 0x00220D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x00222B4C File Offset: 0x00220D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x00222B5C File Offset: 0x00220D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x00222B6C File Offset: 0x00220D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x00222B7C File Offset: 0x00220D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x00222B8C File Offset: 0x00220D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DocumentReadingBeginEvent other)
		{
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x00222B9C File Offset: 0x00220D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00222BAC File Offset: 0x00220DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x00222BBC File Offset: 0x00220DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DocumentReadingBeginEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					DocumentReadingBeginEvent._parser = new MessageParser<DocumentReadingBeginEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00222CA0 File Offset: 0x00220EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CtubiDOFhQuQXQb2cbTb()
		{
			return true;
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x00222CA8 File Offset: 0x00220EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DocumentReadingBeginEvent VJ8Z6cOFroHCrXJeN5yw()
		{
			return null;
		}

		// Token: 0x04002295 RID: 8853
		private static readonly MessageParser<DocumentReadingBeginEvent> _parser;

		// Token: 0x04002296 RID: 8854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002297 RID: 8855
		public const int DocumentIdFieldNumber = 1;

		// Token: 0x04002298 RID: 8856
		private int documentId_;

		// Token: 0x04002299 RID: 8857
		private static DocumentReadingBeginEvent GK6733OFWFcGToa8qiRw;
	}
}
