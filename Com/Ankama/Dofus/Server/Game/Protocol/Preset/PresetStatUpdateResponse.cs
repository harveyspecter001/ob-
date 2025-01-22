using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000246 RID: 582
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetStatUpdateResponse : IMessage<PresetStatUpdateResponse>, IMessage, IEquatable<PresetStatUpdateResponse>, IDeepCloneable<PresetStatUpdateResponse>, IBufferMessage
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x001B0FBC File Offset: 0x001AF1BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetStatUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x001B0FCC File Offset: 0x001AF1CC
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x001B0FDC File Offset: 0x001AF1DC
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

		// Token: 0x06001B1B RID: 6939 RVA: 0x001B0FEC File Offset: 0x001AF1EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateResponse()
		{
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x001B0FFC File Offset: 0x001AF1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateResponse(PresetStatUpdateResponse other)
		{
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x001B100C File Offset: 0x001AF20C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x001B101C File Offset: 0x001AF21C
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x001B102C File Offset: 0x001AF22C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsSuccess
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x001B103C File Offset: 0x001AF23C
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x001B104C File Offset: 0x001AF24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacteristicsInfo CharacteristicsInfo
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

		// Token: 0x06001B22 RID: 6946 RVA: 0x001B105C File Offset: 0x001AF25C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x001B106C File Offset: 0x001AF26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetStatUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x001B107C File Offset: 0x001AF27C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x001B108C File Offset: 0x001AF28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x001B109C File Offset: 0x001AF29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x001B10AC File Offset: 0x001AF2AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x001B10BC File Offset: 0x001AF2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x001B10CC File Offset: 0x001AF2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetStatUpdateResponse other)
		{
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x001B10DC File Offset: 0x001AF2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x001B10EC File Offset: 0x001AF2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x001B10FC File Offset: 0x001AF2FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetStatUpdateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PresetStatUpdateResponse._parser = new MessageParser<PresetStatUpdateResponse>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x001B11E0 File Offset: 0x001AF3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yaAvYEO5JVCtPADU2K5X()
		{
			return true;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x001B11E8 File Offset: 0x001AF3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetStatUpdateResponse COrUIJO5GJr1SqlqEYHe()
		{
			return null;
		}

		// Token: 0x040009A7 RID: 2471
		private static readonly MessageParser<PresetStatUpdateResponse> _parser;

		// Token: 0x040009A8 RID: 2472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009A9 RID: 2473
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x040009AA RID: 2474
		private bool isSuccess_;

		// Token: 0x040009AB RID: 2475
		public const int CharacteristicsInfoFieldNumber = 2;

		// Token: 0x040009AC RID: 2476
		private CharacteristicsInfo characteristicsInfo_;

		// Token: 0x040009AD RID: 2477
		private static PresetStatUpdateResponse mjnQckO5O98e07Ju8Xuw;
	}
}
