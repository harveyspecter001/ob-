using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000830 RID: 2096
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendSetWarnOnConnectionRequest : IMessage<FriendSetWarnOnConnectionRequest>, IMessage, IEquatable<FriendSetWarnOnConnectionRequest>, IDeepCloneable<FriendSetWarnOnConnectionRequest>, IBufferMessage
	{
		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060065D6 RID: 26070 RVA: 0x0022AF6C File Offset: 0x0022916C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendSetWarnOnConnectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060065D7 RID: 26071 RVA: 0x0022AF7C File Offset: 0x0022917C
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060065D8 RID: 26072 RVA: 0x0022AF8C File Offset: 0x0022918C
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

		// Token: 0x060065D9 RID: 26073 RVA: 0x0022AF9C File Offset: 0x0022919C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnConnectionRequest()
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x0022AFAC File Offset: 0x002291AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnConnectionRequest(FriendSetWarnOnConnectionRequest other)
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x0022AFBC File Offset: 0x002291BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnConnectionRequest Clone()
		{
			return null;
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060065DC RID: 26076 RVA: 0x0022AFCC File Offset: 0x002291CC
		// (set) Token: 0x060065DD RID: 26077 RVA: 0x0022AFDC File Offset: 0x002291DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
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

		// Token: 0x060065DE RID: 26078 RVA: 0x0022AFEC File Offset: 0x002291EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x0022AFFC File Offset: 0x002291FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendSetWarnOnConnectionRequest other)
		{
			return true;
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x0022B00C File Offset: 0x0022920C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x0022B01C File Offset: 0x0022921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x0022B02C File Offset: 0x0022922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0022B03C File Offset: 0x0022923C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0022B04C File Offset: 0x0022924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0022B05C File Offset: 0x0022925C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendSetWarnOnConnectionRequest other)
		{
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0022B06C File Offset: 0x0022926C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x0022B07C File Offset: 0x0022927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x0022B08C File Offset: 0x0022928C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendSetWarnOnConnectionRequest()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					FriendSetWarnOnConnectionRequest._parser = new MessageParser<FriendSetWarnOnConnectionRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x0022B158 File Offset: 0x00229358
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aub7r9JfUiEhboLqPOpG()
		{
			return true;
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x0022B160 File Offset: 0x00229360
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendSetWarnOnConnectionRequest p5yZYtJfv3im7xwWIAes()
		{
			return null;
		}

		// Token: 0x040023CD RID: 9165
		private static readonly MessageParser<FriendSetWarnOnConnectionRequest> _parser;

		// Token: 0x040023CE RID: 9166
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023CF RID: 9167
		public const int EnableFieldNumber = 1;

		// Token: 0x040023D0 RID: 9168
		private bool enable_;

		// Token: 0x040023D1 RID: 9169
		internal static FriendSetWarnOnConnectionRequest UNEtuGJfcGIsIGXFVgNn;
	}
}
