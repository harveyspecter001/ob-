using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D2B RID: 3371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRanksRequest : IMessage<AllianceRanksRequest>, IMessage, IEquatable<AllianceRanksRequest>, IDeepCloneable<AllianceRanksRequest>, IBufferMessage
	{
		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x0028A888 File Offset: 0x00288A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRanksRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x0028A898 File Offset: 0x00288A98
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

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x0028A8A8 File Offset: 0x00288AA8
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

		// Token: 0x0600A254 RID: 41556 RVA: 0x0028A8B8 File Offset: 0x00288AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksRequest()
		{
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x0028A8C8 File Offset: 0x00288AC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksRequest(AllianceRanksRequest other)
		{
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x0028A8D8 File Offset: 0x00288AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x0028A8E8 File Offset: 0x00288AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x0028A8F8 File Offset: 0x00288AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRanksRequest other)
		{
			return true;
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x0028A908 File Offset: 0x00288B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x0028A918 File Offset: 0x00288B18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x0028A928 File Offset: 0x00288B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x0028A938 File Offset: 0x00288B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x0028A948 File Offset: 0x00288B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x0028A958 File Offset: 0x00288B58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRanksRequest other)
		{
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x0028A968 File Offset: 0x00288B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x0028A978 File Offset: 0x00288B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x0028A988 File Offset: 0x00288B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRanksRequest()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_35;
					case 3:
						AllianceRanksRequest._parser = new MessageParser<AllianceRanksRequest>(() => null);
						num2 = 4;
						continue;
					case 4:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x0028AA58 File Offset: 0x00288C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gGCCoLJKMZaUr8h4R0jG()
		{
			return true;
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0028AA60 File Offset: 0x00288C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRanksRequest eqswtIJKuxqbC3XEYmSm()
		{
			return null;
		}

		// Token: 0x04003BF0 RID: 15344
		private static readonly MessageParser<AllianceRanksRequest> _parser;

		// Token: 0x04003BF1 RID: 15345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF2 RID: 15346
		private static AllianceRanksRequest OhgjyjJKSAcYVyfPlrqw;
	}
}
