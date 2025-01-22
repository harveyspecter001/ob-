using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000230 RID: 560
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetDeleteResponse : IMessage<PresetDeleteResponse>, IMessage, IEquatable<PresetDeleteResponse>, IDeepCloneable<PresetDeleteResponse>, IBufferMessage
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x001B0250 File Offset: 0x001AE450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetDeleteResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x001B0260 File Offset: 0x001AE460
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x001B0270 File Offset: 0x001AE470
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

		// Token: 0x06001A36 RID: 6710 RVA: 0x001B0280 File Offset: 0x001AE480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteResponse()
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x001B0290 File Offset: 0x001AE490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteResponse(PresetDeleteResponse other)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x001B02A0 File Offset: 0x001AE4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteResponse Clone()
		{
			return null;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x001B02B0 File Offset: 0x001AE4B0
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x001B02C0 File Offset: 0x001AE4C0
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

		// Token: 0x06001A3B RID: 6715 RVA: 0x001B02D0 File Offset: 0x001AE4D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x001B02E0 File Offset: 0x001AE4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetDeleteResponse other)
		{
			return true;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x001B02F0 File Offset: 0x001AE4F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x001B0300 File Offset: 0x001AE500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x001B0310 File Offset: 0x001AE510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x001B0320 File Offset: 0x001AE520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x001B0330 File Offset: 0x001AE530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x001B0340 File Offset: 0x001AE540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetDeleteResponse other)
		{
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x001B0350 File Offset: 0x001AE550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x001B0360 File Offset: 0x001AE560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x001B0370 File Offset: 0x001AE570
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetDeleteResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						PresetDeleteResponse._parser = new MessageParser<PresetDeleteResponse>(() => null);
						num2 = 4;
						break;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						goto IL_5F;
					case 4:
						return;
					}
				}
				IL_5F:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x001B0440 File Offset: 0x001AE640
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SgymPMOaPa84t0vNlg4Q()
		{
			return true;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x001B0448 File Offset: 0x001AE648
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetDeleteResponse orkXhdOaSx0xQnYH0auQ()
		{
			return null;
		}

		// Token: 0x0400094D RID: 2381
		private static readonly MessageParser<PresetDeleteResponse> _parser;

		// Token: 0x0400094E RID: 2382
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400094F RID: 2383
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000950 RID: 2384
		private bool isSuccess_;

		// Token: 0x04000951 RID: 2385
		internal static PresetDeleteResponse OgRs95Oai9yey8hMyphr;
	}
}
