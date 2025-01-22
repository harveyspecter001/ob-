using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000271 RID: 625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetOutfitUpdateResponse : IMessage<PresetOutfitUpdateResponse>, IMessage, IEquatable<PresetOutfitUpdateResponse>, IDeepCloneable<PresetOutfitUpdateResponse>, IBufferMessage
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x001B2F1C File Offset: 0x001B111C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetOutfitUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x001B2F2C File Offset: 0x001B112C
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x001B2F3C File Offset: 0x001B113C
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

		// Token: 0x06001D2E RID: 7470 RVA: 0x001B2F4C File Offset: 0x001B114C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateResponse()
		{
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x001B2F5C File Offset: 0x001B115C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateResponse(PresetOutfitUpdateResponse other)
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x001B2F6C File Offset: 0x001B116C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x001B2F7C File Offset: 0x001B117C
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x001B2F8C File Offset: 0x001B118C
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x001B2F9C File Offset: 0x001B119C
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x001B2FAC File Offset: 0x001B11AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetLook UpdatedLook
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

		// Token: 0x06001D35 RID: 7477 RVA: 0x001B2FBC File Offset: 0x001B11BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x001B2FCC File Offset: 0x001B11CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetOutfitUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x001B2FDC File Offset: 0x001B11DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x001B2FEC File Offset: 0x001B11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x001B2FFC File Offset: 0x001B11FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x001B300C File Offset: 0x001B120C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x001B301C File Offset: 0x001B121C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x001B302C File Offset: 0x001B122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetOutfitUpdateResponse other)
		{
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x001B303C File Offset: 0x001B123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x001B304C File Offset: 0x001B124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x001B305C File Offset: 0x001B125C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetOutfitUpdateResponse()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					PresetOutfitUpdateResponse._parser = new MessageParser<PresetOutfitUpdateResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x001B3154 File Offset: 0x001B1354
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SA9IkBO5bbiafm6f6fJ7()
		{
			return true;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x001B315C File Offset: 0x001B135C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetOutfitUpdateResponse db7Lu0O5iB3fu3HmE9i5()
		{
			return null;
		}

		// Token: 0x04000A55 RID: 2645
		private static readonly MessageParser<PresetOutfitUpdateResponse> _parser;

		// Token: 0x04000A56 RID: 2646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A57 RID: 2647
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000A58 RID: 2648
		private bool isSuccess_;

		// Token: 0x04000A59 RID: 2649
		public const int UpdatedLookFieldNumber = 2;

		// Token: 0x04000A5A RID: 2650
		private PresetLook updatedLook_;

		// Token: 0x04000A5B RID: 2651
		private static PresetOutfitUpdateResponse ruX0XwO5YAfQeJeS37Rk;
	}
}
