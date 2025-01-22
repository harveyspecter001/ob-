using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation
{
	// Token: 0x02000397 RID: 919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PopupWarningEvent : IMessage<PopupWarningEvent>, IMessage, IEquatable<PopupWarningEvent>, IDeepCloneable<PopupWarningEvent>, IBufferMessage
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x001C9C00 File Offset: 0x001C7E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PopupWarningEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x001C9C10 File Offset: 0x001C7E10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x001C9C20 File Offset: 0x001C7E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x001C9C30 File Offset: 0x001C7E30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningEvent()
		{
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x001C9C40 File Offset: 0x001C7E40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningEvent(PopupWarningEvent other)
		{
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x001C9C50 File Offset: 0x001C7E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningEvent Clone()
		{
			return null;
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x001C9C60 File Offset: 0x001C7E60
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x001C9C70 File Offset: 0x001C7E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LockDuration
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x001C9C80 File Offset: 0x001C7E80
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x001C9C90 File Offset: 0x001C7E90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Author
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x001C9CA0 File Offset: 0x001C7EA0
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x001C9CB0 File Offset: 0x001C7EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x001C9CC0 File Offset: 0x001C7EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x001C9CD0 File Offset: 0x001C7ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PopupWarningEvent other)
		{
			return true;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x001C9CE0 File Offset: 0x001C7EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x001C9CF0 File Offset: 0x001C7EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x001C9D00 File Offset: 0x001C7F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x001C9D10 File Offset: 0x001C7F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x001C9D20 File Offset: 0x001C7F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x001C9D30 File Offset: 0x001C7F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PopupWarningEvent other)
		{
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x001C9D40 File Offset: 0x001C7F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x001C9D50 File Offset: 0x001C7F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x001C9D60 File Offset: 0x001C7F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PopupWarningEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					PopupWarningEvent._parser = new MessageParser<PopupWarningEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x001C9E44 File Offset: 0x001C8044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ES62B4OrSN6IpQnxX14t()
		{
			return true;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x001C9E4C File Offset: 0x001C804C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PopupWarningEvent ysuyuGOrM4SkfoMwskfq()
		{
			return null;
		}

		// Token: 0x04000F2B RID: 3883
		private static readonly MessageParser<PopupWarningEvent> _parser;

		// Token: 0x04000F2C RID: 3884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F2D RID: 3885
		public const int LockDurationFieldNumber = 1;

		// Token: 0x04000F2E RID: 3886
		private int lockDuration_;

		// Token: 0x04000F2F RID: 3887
		public const int AuthorFieldNumber = 2;

		// Token: 0x04000F30 RID: 3888
		private string author_;

		// Token: 0x04000F31 RID: 3889
		public const int ContentFieldNumber = 3;

		// Token: 0x04000F32 RID: 3890
		private string content_;

		// Token: 0x04000F33 RID: 3891
		private static PopupWarningEvent EG71SeOrPgESHNPkRKHX;
	}
}
