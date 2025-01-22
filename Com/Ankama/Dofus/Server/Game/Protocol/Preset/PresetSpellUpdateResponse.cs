using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200023F RID: 575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSpellUpdateResponse : IMessage<PresetSpellUpdateResponse>, IMessage, IEquatable<PresetSpellUpdateResponse>, IDeepCloneable<PresetSpellUpdateResponse>, IBufferMessage
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x001B0B60 File Offset: 0x001AED60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetSpellUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x001B0B70 File Offset: 0x001AED70
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x001B0B80 File Offset: 0x001AED80
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

		// Token: 0x06001AC9 RID: 6857 RVA: 0x001B0B90 File Offset: 0x001AED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateResponse()
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x001B0BA0 File Offset: 0x001AEDA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateResponse(PresetSpellUpdateResponse other)
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x001B0BB0 File Offset: 0x001AEDB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x001B0BC0 File Offset: 0x001AEDC0
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x001B0BD0 File Offset: 0x001AEDD0
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

		// Token: 0x06001ACE RID: 6862 RVA: 0x001B0BE0 File Offset: 0x001AEDE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x001B0BF0 File Offset: 0x001AEDF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSpellUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x001B0C00 File Offset: 0x001AEE00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x001B0C10 File Offset: 0x001AEE10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x001B0C20 File Offset: 0x001AEE20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x001B0C30 File Offset: 0x001AEE30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x001B0C40 File Offset: 0x001AEE40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x001B0C50 File Offset: 0x001AEE50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSpellUpdateResponse other)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x001B0C60 File Offset: 0x001AEE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x001B0C70 File Offset: 0x001AEE70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x001B0C80 File Offset: 0x001AEE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSpellUpdateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					PresetSpellUpdateResponse._parser = new MessageParser<PresetSpellUpdateResponse>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x001B0D64 File Offset: 0x001AEF64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pfsqXrO5At9W3UVrAoPa()
		{
			return true;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x001B0D6C File Offset: 0x001AEF6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSpellUpdateResponse B5Y2npO5BYweUnOHtF3L()
		{
			return null;
		}

		// Token: 0x0400098D RID: 2445
		private static readonly MessageParser<PresetSpellUpdateResponse> _parser;

		// Token: 0x0400098E RID: 2446
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400098F RID: 2447
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000990 RID: 2448
		private bool isSuccess_;

		// Token: 0x04000991 RID: 2449
		internal static PresetSpellUpdateResponse M3D8u9O5maibtQrFQBKH;
	}
}
