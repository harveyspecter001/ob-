using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D51 RID: 3409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceModificationValidRequest : IMessage<AllianceModificationValidRequest>, IMessage, IEquatable<AllianceModificationValidRequest>, IDeepCloneable<AllianceModificationValidRequest>, IBufferMessage
	{
		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600A43B RID: 42043 RVA: 0x0028EFFC File Offset: 0x0028D1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceModificationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x0028F00C File Offset: 0x0028D20C
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

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600A43D RID: 42045 RVA: 0x0028F01C File Offset: 0x0028D21C
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

		// Token: 0x0600A43E RID: 42046 RVA: 0x0028F02C File Offset: 0x0028D22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationValidRequest()
		{
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x0028F03C File Offset: 0x0028D23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationValidRequest(AllianceModificationValidRequest other)
		{
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x0028F04C File Offset: 0x0028D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600A441 RID: 42049 RVA: 0x0028F05C File Offset: 0x0028D25C
		// (set) Token: 0x0600A442 RID: 42050 RVA: 0x0028F06C File Offset: 0x0028D26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AllianceName
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

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600A443 RID: 42051 RVA: 0x0028F07C File Offset: 0x0028D27C
		// (set) Token: 0x0600A444 RID: 42052 RVA: 0x0028F08C File Offset: 0x0028D28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceTag
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

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x0600A445 RID: 42053 RVA: 0x0028F09C File Offset: 0x0028D29C
		// (set) Token: 0x0600A446 RID: 42054 RVA: 0x0028F0AC File Offset: 0x0028D2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEmblem AllianceEmblem
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

		// Token: 0x0600A447 RID: 42055 RVA: 0x0028F0BC File Offset: 0x0028D2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x0028F0CC File Offset: 0x0028D2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceModificationValidRequest other)
		{
			return true;
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x0028F0DC File Offset: 0x0028D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0028F0EC File Offset: 0x0028D2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x0028F0FC File Offset: 0x0028D2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x0028F10C File Offset: 0x0028D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x0028F11C File Offset: 0x0028D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x0028F12C File Offset: 0x0028D32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceModificationValidRequest other)
		{
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x0028F13C File Offset: 0x0028D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x0028F14C File Offset: 0x0028D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x0028F15C File Offset: 0x0028D35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceModificationValidRequest()
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
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_9C;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
						{
							num2 = 2;
						}
						break;
					}
				}
				IL_9C:
				AllianceModificationValidRequest._parser = new MessageParser<AllianceModificationValidRequest>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0028F22C File Offset: 0x0028D42C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vlY1XvJIPBnvLXY7GCdn()
		{
			return true;
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0028F234 File Offset: 0x0028D434
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceModificationValidRequest fXpOPlJISmuYU9WFcPFw()
		{
			return null;
		}

		// Token: 0x04003C84 RID: 15492
		private static readonly MessageParser<AllianceModificationValidRequest> _parser;

		// Token: 0x04003C85 RID: 15493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C86 RID: 15494
		public const int AllianceNameFieldNumber = 1;

		// Token: 0x04003C87 RID: 15495
		private string allianceName_;

		// Token: 0x04003C88 RID: 15496
		public const int AllianceTagFieldNumber = 2;

		// Token: 0x04003C89 RID: 15497
		private string allianceTag_;

		// Token: 0x04003C8A RID: 15498
		public const int AllianceEmblemFieldNumber = 3;

		// Token: 0x04003C8B RID: 15499
		private SocialEmblem allianceEmblem_;

		// Token: 0x04003C8C RID: 15500
		internal static AllianceModificationValidRequest DjGRwWJIi31fkgUPGFoD;
	}
}
