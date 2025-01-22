using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200082C RID: 2092
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendAddRequest : IMessage<FriendAddRequest>, IMessage, IEquatable<FriendAddRequest>, IDeepCloneable<FriendAddRequest>, IBufferMessage
	{
		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x0022AB44 File Offset: 0x00228D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendAddRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x0022AB54 File Offset: 0x00228D54
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

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x0022AB64 File Offset: 0x00228D64
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

		// Token: 0x060065A5 RID: 26021 RVA: 0x0022AB74 File Offset: 0x00228D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddRequest()
		{
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x0022AB84 File Offset: 0x00228D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddRequest(FriendAddRequest other)
		{
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x0022AB94 File Offset: 0x00228D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddRequest Clone()
		{
			return null;
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060065A8 RID: 26024 RVA: 0x0022ABA4 File Offset: 0x00228DA4
		// (set) Token: 0x060065A9 RID: 26025 RVA: 0x0022ABB4 File Offset: 0x00228DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSearch Target
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

		// Token: 0x060065AA RID: 26026 RVA: 0x0022ABC4 File Offset: 0x00228DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x0022ABD4 File Offset: 0x00228DD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendAddRequest other)
		{
			return true;
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x0022ABE4 File Offset: 0x00228DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x0022ABF4 File Offset: 0x00228DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x0022AC04 File Offset: 0x00228E04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x0022AC14 File Offset: 0x00228E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x0022AC24 File Offset: 0x00228E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0022AC34 File Offset: 0x00228E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendAddRequest other)
		{
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x0022AC44 File Offset: 0x00228E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x0022AC54 File Offset: 0x00228E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x0022AC64 File Offset: 0x00228E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendAddRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FriendAddRequest._parser = new MessageParser<FriendAddRequest>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x0022AD48 File Offset: 0x00228F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hZP2fcJfjCy8Idu2oe0S()
		{
			return true;
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x0022AD50 File Offset: 0x00228F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendAddRequest ggeIhhJfKd3ZSEGpGi4u()
		{
			return null;
		}

		// Token: 0x040023BF RID: 9151
		private static readonly MessageParser<FriendAddRequest> _parser;

		// Token: 0x040023C0 RID: 9152
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C1 RID: 9153
		public const int TargetFieldNumber = 1;

		// Token: 0x040023C2 RID: 9154
		private PlayerSearch target_;

		// Token: 0x040023C3 RID: 9155
		internal static FriendAddRequest YplJUYJf4j2TDeKpvTWt;
	}
}
