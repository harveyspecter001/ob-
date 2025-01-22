using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C9D RID: 3229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryPopObjectRequest : IMessage<CosmeticInventoryPopObjectRequest>, IMessage, IEquatable<CosmeticInventoryPopObjectRequest>, IDeepCloneable<CosmeticInventoryPopObjectRequest>, IBufferMessage
	{
		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x0027FA70 File Offset: 0x0027DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CosmeticInventoryPopObjectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06009B07 RID: 39687 RVA: 0x0027FA80 File Offset: 0x0027DC80
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

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x0027FA90 File Offset: 0x0027DC90
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

		// Token: 0x06009B09 RID: 39689 RVA: 0x0027FAA0 File Offset: 0x0027DCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectRequest()
		{
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0027FAB0 File Offset: 0x0027DCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectRequest(CosmeticInventoryPopObjectRequest other)
		{
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x0027FAC0 File Offset: 0x0027DCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x0027FAD0 File Offset: 0x0027DCD0
		// (set) Token: 0x06009B0D RID: 39693 RVA: 0x0027FAE0 File Offset: 0x0027DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Gid
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

		// Token: 0x06009B0E RID: 39694 RVA: 0x0027FAF0 File Offset: 0x0027DCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x0027FB00 File Offset: 0x0027DD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryPopObjectRequest other)
		{
			return true;
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x0027FB10 File Offset: 0x0027DD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0027FB20 File Offset: 0x0027DD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x0027FB30 File Offset: 0x0027DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0027FB40 File Offset: 0x0027DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x0027FB50 File Offset: 0x0027DD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x0027FB60 File Offset: 0x0027DD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryPopObjectRequest other)
		{
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x0027FB70 File Offset: 0x0027DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x0027FB80 File Offset: 0x0027DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x0027FB90 File Offset: 0x0027DD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryPopObjectRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					CosmeticInventoryPopObjectRequest._parser = new MessageParser<CosmeticInventoryPopObjectRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0027FC88 File Offset: 0x0027DE88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yAkLuyJxhPEYCbiYUF1l()
		{
			return true;
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x0027FC90 File Offset: 0x0027DE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryPopObjectRequest xESdFxJxre11uk5N2ah3()
		{
			return null;
		}

		// Token: 0x04003995 RID: 14741
		private static readonly MessageParser<CosmeticInventoryPopObjectRequest> _parser;

		// Token: 0x04003996 RID: 14742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003997 RID: 14743
		public const int GidFieldNumber = 1;

		// Token: 0x04003998 RID: 14744
		private int gid_;

		// Token: 0x04003999 RID: 14745
		internal static CosmeticInventoryPopObjectRequest kFrAsuJxWtbUbyu4PIyv;
	}
}
