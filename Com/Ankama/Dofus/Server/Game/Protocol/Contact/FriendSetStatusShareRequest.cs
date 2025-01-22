using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000834 RID: 2100
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendSetStatusShareRequest : IMessage<FriendSetStatusShareRequest>, IMessage, IEquatable<FriendSetStatusShareRequest>, IDeepCloneable<FriendSetStatusShareRequest>, IBufferMessage
	{
		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x0022B364 File Offset: 0x00229564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendSetStatusShareRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x0022B374 File Offset: 0x00229574
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

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x0022B384 File Offset: 0x00229584
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

		// Token: 0x0600660D RID: 26125 RVA: 0x0022B394 File Offset: 0x00229594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetStatusShareRequest()
		{
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x0022B3A4 File Offset: 0x002295A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetStatusShareRequest(FriendSetStatusShareRequest other)
		{
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x0022B3B4 File Offset: 0x002295B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetStatusShareRequest Clone()
		{
			return null;
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06006610 RID: 26128 RVA: 0x0022B3C4 File Offset: 0x002295C4
		// (set) Token: 0x06006611 RID: 26129 RVA: 0x0022B3D4 File Offset: 0x002295D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Share
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

		// Token: 0x06006612 RID: 26130 RVA: 0x0022B3E4 File Offset: 0x002295E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0022B3F4 File Offset: 0x002295F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendSetStatusShareRequest other)
		{
			return true;
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x0022B404 File Offset: 0x00229604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x0022B414 File Offset: 0x00229614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x0022B424 File Offset: 0x00229624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x0022B434 File Offset: 0x00229634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x0022B444 File Offset: 0x00229644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x0022B454 File Offset: 0x00229654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendSetStatusShareRequest other)
		{
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x0022B464 File Offset: 0x00229664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x0022B474 File Offset: 0x00229674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0022B484 File Offset: 0x00229684
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendSetStatusShareRequest()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FriendSetStatusShareRequest._parser = new MessageParser<FriendSetStatusShareRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0022B550 File Offset: 0x00229750
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NBi5osJfyGlJsFBcAMqa()
		{
			return true;
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x0022B558 File Offset: 0x00229758
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendSetStatusShareRequest QrHTGAJf6dVEcuN09CGX()
		{
			return null;
		}

		// Token: 0x040023DB RID: 9179
		private static readonly MessageParser<FriendSetStatusShareRequest> _parser;

		// Token: 0x040023DC RID: 9180
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023DD RID: 9181
		public const int ShareFieldNumber = 1;

		// Token: 0x040023DE RID: 9182
		private bool share_;

		// Token: 0x040023DF RID: 9183
		private static FriendSetStatusShareRequest lnvtN7Jf5esb29Bes25V;
	}
}
