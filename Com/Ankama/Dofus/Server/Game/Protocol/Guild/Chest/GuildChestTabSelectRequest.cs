using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000534 RID: 1332
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabSelectRequest : IMessage<GuildChestTabSelectRequest>, IMessage, IEquatable<GuildChestTabSelectRequest>, IDeepCloneable<GuildChestTabSelectRequest>, IBufferMessage
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x001EDEBC File Offset: 0x001EC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestTabSelectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x001EDECC File Offset: 0x001EC0CC
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

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x001EDEDC File Offset: 0x001EC0DC
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

		// Token: 0x06003FEF RID: 16367 RVA: 0x001EDEEC File Offset: 0x001EC0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabSelectRequest()
		{
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x001EDEFC File Offset: 0x001EC0FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabSelectRequest(GuildChestTabSelectRequest other)
		{
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x001EDF0C File Offset: 0x001EC10C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabSelectRequest Clone()
		{
			return null;
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x001EDF1C File Offset: 0x001EC11C
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x001EDF2C File Offset: 0x001EC12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabNumber
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

		// Token: 0x06003FF4 RID: 16372 RVA: 0x001EDF3C File Offset: 0x001EC13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x001EDF4C File Offset: 0x001EC14C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabSelectRequest other)
		{
			return true;
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001EDF5C File Offset: 0x001EC15C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x001EDF6C File Offset: 0x001EC16C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x001EDF7C File Offset: 0x001EC17C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x001EDF8C File Offset: 0x001EC18C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x001EDF9C File Offset: 0x001EC19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x001EDFAC File Offset: 0x001EC1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabSelectRequest other)
		{
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x001EDFBC File Offset: 0x001EC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x001EDFCC File Offset: 0x001EC1CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x001EDFDC File Offset: 0x001EC1DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabSelectRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					GuildChestTabSelectRequest._parser = new MessageParser<GuildChestTabSelectRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x001EE0A8 File Offset: 0x001EC2A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dPraCoOpKNMMYZSMjsaA()
		{
			return true;
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x001EE0B0 File Offset: 0x001EC2B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabSelectRequest FpOWaiOpIXtX0jX6Trjp()
		{
			return null;
		}

		// Token: 0x0400161F RID: 5663
		private static readonly MessageParser<GuildChestTabSelectRequest> _parser;

		// Token: 0x04001620 RID: 5664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001621 RID: 5665
		public const int TabNumberFieldNumber = 1;

		// Token: 0x04001622 RID: 5666
		private int tabNumber_;

		// Token: 0x04001623 RID: 5667
		private static GuildChestTabSelectRequest aYdICrOpjgnXqEWbDm4b;
	}
}
