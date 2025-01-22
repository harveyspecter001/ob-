using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200082E RID: 2094
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendDeleteRequest : IMessage<FriendDeleteRequest>, IMessage, IEquatable<FriendDeleteRequest>, IDeepCloneable<FriendDeleteRequest>, IBufferMessage
	{
		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x0022AD58 File Offset: 0x00228F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendDeleteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x0022AD68 File Offset: 0x00228F68
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

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060065BE RID: 26046 RVA: 0x0022AD78 File Offset: 0x00228F78
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

		// Token: 0x060065BF RID: 26047 RVA: 0x0022AD88 File Offset: 0x00228F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeleteRequest()
		{
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x0022AD98 File Offset: 0x00228F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeleteRequest(FriendDeleteRequest other)
		{
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x0022ADA8 File Offset: 0x00228FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeleteRequest Clone()
		{
			return null;
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060065C2 RID: 26050 RVA: 0x0022ADB8 File Offset: 0x00228FB8
		// (set) Token: 0x060065C3 RID: 26051 RVA: 0x0022ADC8 File Offset: 0x00228FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccountId
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

		// Token: 0x060065C4 RID: 26052 RVA: 0x0022ADD8 File Offset: 0x00228FD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x0022ADE8 File Offset: 0x00228FE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendDeleteRequest other)
		{
			return true;
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0022ADF8 File Offset: 0x00228FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x0022AE08 File Offset: 0x00229008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x0022AE18 File Offset: 0x00229018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x0022AE28 File Offset: 0x00229028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x0022AE38 File Offset: 0x00229038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x0022AE48 File Offset: 0x00229048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendDeleteRequest other)
		{
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x0022AE58 File Offset: 0x00229058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x0022AE68 File Offset: 0x00229068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x0022AE78 File Offset: 0x00229078
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendDeleteRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FriendDeleteRequest._parser = new MessageParser<FriendDeleteRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x0022AF5C File Offset: 0x0022915C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EiuusJJfkLEa4ZEg3xxF()
		{
			return true;
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x0022AF64 File Offset: 0x00229164
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendDeleteRequest H3mKlgJflUuhgpCar0XG()
		{
			return null;
		}

		// Token: 0x040023C6 RID: 9158
		private static readonly MessageParser<FriendDeleteRequest> _parser;

		// Token: 0x040023C7 RID: 9159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C8 RID: 9160
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040023C9 RID: 9161
		private long accountId_;

		// Token: 0x040023CA RID: 9162
		internal static FriendDeleteRequest HIHL0MJfIoxpM7X01Yy4;
	}
}
