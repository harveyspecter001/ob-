using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003EE RID: 1006
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectUseOnCharacterRequest : IMessage<ObjectUseOnCharacterRequest>, IMessage, IEquatable<ObjectUseOnCharacterRequest>, IDeepCloneable<ObjectUseOnCharacterRequest>, IBufferMessage
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x001D2884 File Offset: 0x001D0A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectUseOnCharacterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x001D2894 File Offset: 0x001D0A94
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

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x001D28A4 File Offset: 0x001D0AA4
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

		// Token: 0x06002F67 RID: 12135 RVA: 0x001D28B4 File Offset: 0x001D0AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCharacterRequest()
		{
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x001D28C4 File Offset: 0x001D0AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCharacterRequest(ObjectUseOnCharacterRequest other)
		{
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x001D28D4 File Offset: 0x001D0AD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCharacterRequest Clone()
		{
			return null;
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x001D28E4 File Offset: 0x001D0AE4
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x001D28F4 File Offset: 0x001D0AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectUid
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x001D2904 File Offset: 0x001D0B04
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x001D2914 File Offset: 0x001D0B14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x001D2924 File Offset: 0x001D0B24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x001D2934 File Offset: 0x001D0B34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectUseOnCharacterRequest other)
		{
			return true;
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x001D2944 File Offset: 0x001D0B44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x001D2954 File Offset: 0x001D0B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x001D2964 File Offset: 0x001D0B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x001D2974 File Offset: 0x001D0B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x001D2984 File Offset: 0x001D0B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x001D2994 File Offset: 0x001D0B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectUseOnCharacterRequest other)
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x001D29A4 File Offset: 0x001D0BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x001D29B4 File Offset: 0x001D0BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x001D29C4 File Offset: 0x001D0BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectUseOnCharacterRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_35;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				ObjectUseOnCharacterRequest._parser = new MessageParser<ObjectUseOnCharacterRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x001D2AAC File Offset: 0x001D0CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JoQAvNO0rukGl4pX3Ljr()
		{
			return true;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x001D2AB4 File Offset: 0x001D0CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectUseOnCharacterRequest f6b2L2O0VgvWvJfwH8Mp()
		{
			return null;
		}

		// Token: 0x040010AA RID: 4266
		private static readonly MessageParser<ObjectUseOnCharacterRequest> _parser;

		// Token: 0x040010AB RID: 4267
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010AC RID: 4268
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x040010AD RID: 4269
		private int objectUid_;

		// Token: 0x040010AE RID: 4270
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040010AF RID: 4271
		private long playerId_;

		// Token: 0x040010B0 RID: 4272
		private static ObjectUseOnCharacterRequest Xxu3oPO0hqEpqNxkRNZt;
	}
}
