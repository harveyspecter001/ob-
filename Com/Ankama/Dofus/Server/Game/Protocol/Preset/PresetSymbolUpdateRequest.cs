using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200025F RID: 607
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSymbolUpdateRequest : IMessage<PresetSymbolUpdateRequest>, IMessage, IEquatable<PresetSymbolUpdateRequest>, IDeepCloneable<PresetSymbolUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x001B1B48 File Offset: 0x001AFD48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetSymbolUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x001B1B58 File Offset: 0x001AFD58
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x001B1B68 File Offset: 0x001AFD68
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

		// Token: 0x06001C34 RID: 7220 RVA: 0x001B1B78 File Offset: 0x001AFD78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateRequest()
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x001B1B88 File Offset: 0x001AFD88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateRequest(PresetSymbolUpdateRequest other)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x001B1B98 File Offset: 0x001AFD98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x001B1BA8 File Offset: 0x001AFDA8
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x001B1BB8 File Offset: 0x001AFDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUuid
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x001B1BC8 File Offset: 0x001AFDC8
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x001B1BDC File Offset: 0x001AFDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetType PresetType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x001B1BEC File Offset: 0x001AFDEC
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x001B1BFC File Offset: 0x001AFDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SymbolId
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

		// Token: 0x06001C3D RID: 7229 RVA: 0x001B1C0C File Offset: 0x001AFE0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x001B1C1C File Offset: 0x001AFE1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSymbolUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x001B1C2C File Offset: 0x001AFE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x001B1C3C File Offset: 0x001AFE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x001B1C4C File Offset: 0x001AFE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x001B1C5C File Offset: 0x001AFE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x001B1C6C File Offset: 0x001AFE6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x001B1C7C File Offset: 0x001AFE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSymbolUpdateRequest other)
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x001B1C8C File Offset: 0x001AFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x001B1C9C File Offset: 0x001AFE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x001B1CAC File Offset: 0x001AFEAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSymbolUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					PresetSymbolUpdateRequest._parser = new MessageParser<PresetSymbolUpdateRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x001B1D90 File Offset: 0x001AFF90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kQDQVXO5kcg5Q79Y9eZR()
		{
			return true;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x001B1D98 File Offset: 0x001AFF98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSymbolUpdateRequest EsV3xfO5l1uBArQeGNuJ()
		{
			return null;
		}

		// Token: 0x04000A07 RID: 2567
		private static readonly MessageParser<PresetSymbolUpdateRequest> _parser;

		// Token: 0x04000A08 RID: 2568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A09 RID: 2569
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000A0A RID: 2570
		private string presetUuid_;

		// Token: 0x04000A0B RID: 2571
		public const int PresetTypeFieldNumber = 2;

		// Token: 0x04000A0C RID: 2572
		private PresetType presetType_;

		// Token: 0x04000A0D RID: 2573
		public const int SymbolIdFieldNumber = 3;

		// Token: 0x04000A0E RID: 2574
		private int symbolId_;

		// Token: 0x04000A0F RID: 2575
		internal static PresetSymbolUpdateRequest t5qeqBO5IwWWjRcPGSsg;
	}
}
