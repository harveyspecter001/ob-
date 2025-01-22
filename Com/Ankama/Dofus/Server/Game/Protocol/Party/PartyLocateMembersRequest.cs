using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000296 RID: 662
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyLocateMembersRequest : IMessage<PartyLocateMembersRequest>, IMessage, IEquatable<PartyLocateMembersRequest>, IDeepCloneable<PartyLocateMembersRequest>, IBufferMessage
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x001B8118 File Offset: 0x001B6318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyLocateMembersRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x001B8128 File Offset: 0x001B6328
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x001B8138 File Offset: 0x001B6338
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

		// Token: 0x06001EEB RID: 7915 RVA: 0x001B8148 File Offset: 0x001B6348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLocateMembersRequest()
		{
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x001B8158 File Offset: 0x001B6358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLocateMembersRequest(PartyLocateMembersRequest other)
		{
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x001B8168 File Offset: 0x001B6368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLocateMembersRequest Clone()
		{
			return null;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x001B8178 File Offset: 0x001B6378
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x001B8188 File Offset: 0x001B6388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x06001EF0 RID: 7920 RVA: 0x001B8198 File Offset: 0x001B6398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x001B81A8 File Offset: 0x001B63A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyLocateMembersRequest other)
		{
			return true;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x001B81B8 File Offset: 0x001B63B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x001B81C8 File Offset: 0x001B63C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x001B81D8 File Offset: 0x001B63D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x001B81E8 File Offset: 0x001B63E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x001B81F8 File Offset: 0x001B63F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x001B8208 File Offset: 0x001B6408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyLocateMembersRequest other)
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x001B8218 File Offset: 0x001B6418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x001B8228 File Offset: 0x001B6428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x001B8238 File Offset: 0x001B6438
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyLocateMembersRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					PartyLocateMembersRequest._parser = new MessageParser<PartyLocateMembersRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x001B8330 File Offset: 0x001B6530
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K8JFOOOyhEGAV3PQ8Krl()
		{
			return true;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x001B8338 File Offset: 0x001B6538
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyLocateMembersRequest eMHCDsOyrLWxR1OScyAD()
		{
			return null;
		}

		// Token: 0x04000AEE RID: 2798
		private static readonly MessageParser<PartyLocateMembersRequest> _parser;

		// Token: 0x04000AEF RID: 2799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AF0 RID: 2800
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AF1 RID: 2801
		private int partyId_;

		// Token: 0x04000AF2 RID: 2802
		internal static PartyLocateMembersRequest d8DwlVOyWnpxonNSPTbZ;
	}
}
