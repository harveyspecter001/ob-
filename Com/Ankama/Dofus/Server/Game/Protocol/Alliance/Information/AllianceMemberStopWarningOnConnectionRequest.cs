using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D55 RID: 3413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMemberStopWarningOnConnectionRequest : IMessage<AllianceMemberStopWarningOnConnectionRequest>, IMessage, IEquatable<AllianceMemberStopWarningOnConnectionRequest>, IDeepCloneable<AllianceMemberStopWarningOnConnectionRequest>, IBufferMessage
	{
		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x0028F430 File Offset: 0x0028D630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceMemberStopWarningOnConnectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600A472 RID: 42098 RVA: 0x0028F440 File Offset: 0x0028D640
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

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x0028F450 File Offset: 0x0028D650
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

		// Token: 0x0600A474 RID: 42100 RVA: 0x0028F460 File Offset: 0x0028D660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStopWarningOnConnectionRequest()
		{
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x0028F470 File Offset: 0x0028D670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStopWarningOnConnectionRequest(AllianceMemberStopWarningOnConnectionRequest other)
		{
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x0028F480 File Offset: 0x0028D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStopWarningOnConnectionRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x0028F490 File Offset: 0x0028D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x0028F4A0 File Offset: 0x0028D6A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMemberStopWarningOnConnectionRequest other)
		{
			return true;
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x0028F4B0 File Offset: 0x0028D6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x0028F4C0 File Offset: 0x0028D6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x0028F4D0 File Offset: 0x0028D6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x0028F4E0 File Offset: 0x0028D6E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x0028F4F0 File Offset: 0x0028D6F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x0028F500 File Offset: 0x0028D700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMemberStopWarningOnConnectionRequest other)
		{
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x0028F510 File Offset: 0x0028D710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x0028F520 File Offset: 0x0028D720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x0028F530 File Offset: 0x0028D730
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMemberStopWarningOnConnectionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_35;
					}
					AllianceMemberStopWarningOnConnectionRequest._parser = new MessageParser<AllianceMemberStopWarningOnConnectionRequest>(() => null);
					num2 = 2;
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x0028F600 File Offset: 0x0028D800
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sYLY3UJIqtHeJZHHrxCl()
		{
			return true;
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x0028F608 File Offset: 0x0028D808
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMemberStopWarningOnConnectionRequest AJx7UcJIFJCaJjyAw6BA()
		{
			return null;
		}

		// Token: 0x04003C94 RID: 15508
		private static readonly MessageParser<AllianceMemberStopWarningOnConnectionRequest> _parser;

		// Token: 0x04003C95 RID: 15509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C96 RID: 15510
		private static AllianceMemberStopWarningOnConnectionRequest VrCwWXJIZWYKuecGpb2w;
	}
}
