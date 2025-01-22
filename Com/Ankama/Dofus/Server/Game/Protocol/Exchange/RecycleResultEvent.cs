using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020007AE RID: 1966
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RecycleResultEvent : IMessage<RecycleResultEvent>, IMessage, IEquatable<RecycleResultEvent>, IDeepCloneable<RecycleResultEvent>, IBufferMessage
	{
		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x0021F9AC File Offset: 0x0021DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecycleResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x0021F9BC File Offset: 0x0021DBBC
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

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x0021F9CC File Offset: 0x0021DBCC
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

		// Token: 0x06006068 RID: 24680 RVA: 0x0021F9DC File Offset: 0x0021DBDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecycleResultEvent()
		{
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x0021F9EC File Offset: 0x0021DBEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecycleResultEvent(RecycleResultEvent other)
		{
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x0021F9FC File Offset: 0x0021DBFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecycleResultEvent Clone()
		{
			return null;
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x0021FA0C File Offset: 0x0021DC0C
		// (set) Token: 0x0600606C RID: 24684 RVA: 0x0021FA1C File Offset: 0x0021DC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PrismNuggets
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

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x0021FA2C File Offset: 0x0021DC2C
		// (set) Token: 0x0600606E RID: 24686 RVA: 0x0021FA3C File Offset: 0x0021DC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerNuggets
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

		// Token: 0x0600606F RID: 24687 RVA: 0x0021FA4C File Offset: 0x0021DC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x0021FA5C File Offset: 0x0021DC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RecycleResultEvent other)
		{
			return true;
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x0021FA6C File Offset: 0x0021DC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x0021FA7C File Offset: 0x0021DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x0021FA8C File Offset: 0x0021DC8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x0021FA9C File Offset: 0x0021DC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x0021FAAC File Offset: 0x0021DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x0021FABC File Offset: 0x0021DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RecycleResultEvent other)
		{
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x0021FACC File Offset: 0x0021DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x0021FADC File Offset: 0x0021DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x0021FAEC File Offset: 0x0021DCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RecycleResultEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					RecycleResultEvent._parser = new MessageParser<RecycleResultEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x0021FBB8 File Offset: 0x0021DDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D0PQGMOqQuKblGgHYN09()
		{
			return true;
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x0021FBC0 File Offset: 0x0021DDC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RecycleResultEvent PeRdHxOq7tsCWdkn6AQM()
		{
			return null;
		}

		// Token: 0x040021E4 RID: 8676
		private static readonly MessageParser<RecycleResultEvent> _parser;

		// Token: 0x040021E5 RID: 8677
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021E6 RID: 8678
		public const int PrismNuggetsFieldNumber = 1;

		// Token: 0x040021E7 RID: 8679
		private int prismNuggets_;

		// Token: 0x040021E8 RID: 8680
		public const int PlayerNuggetsFieldNumber = 2;

		// Token: 0x040021E9 RID: 8681
		private int playerNuggets_;

		// Token: 0x040021EA RID: 8682
		internal static RecycleResultEvent Ku0yrhOqwLXL8tlGGnup;
	}
}
