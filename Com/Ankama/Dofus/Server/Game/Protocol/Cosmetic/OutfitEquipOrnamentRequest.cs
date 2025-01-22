using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CAD RID: 3245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipOrnamentRequest : IMessage<OutfitEquipOrnamentRequest>, IMessage, IEquatable<OutfitEquipOrnamentRequest>, IDeepCloneable<OutfitEquipOrnamentRequest>, IBufferMessage
	{
		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x00280B64 File Offset: 0x0027ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipOrnamentRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x00280B74 File Offset: 0x0027ED74
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

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x00280B84 File Offset: 0x0027ED84
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

		// Token: 0x06009BDF RID: 39903 RVA: 0x00280B94 File Offset: 0x0027ED94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentRequest()
		{
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x00280BA4 File Offset: 0x0027EDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentRequest(OutfitEquipOrnamentRequest other)
		{
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x00280BB4 File Offset: 0x0027EDB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06009BE2 RID: 39906 RVA: 0x00280BC4 File Offset: 0x0027EDC4
		// (set) Token: 0x06009BE3 RID: 39907 RVA: 0x00280BD4 File Offset: 0x0027EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
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

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06009BE4 RID: 39908 RVA: 0x00280BE4 File Offset: 0x0027EDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOrnamentId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x00280BF4 File Offset: 0x0027EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOrnamentId()
		{
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x00280C04 File Offset: 0x0027EE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x00280C14 File Offset: 0x0027EE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipOrnamentRequest other)
		{
			return true;
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x00280C24 File Offset: 0x0027EE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x00280C34 File Offset: 0x0027EE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009BEA RID: 39914 RVA: 0x00280C44 File Offset: 0x0027EE44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009BEB RID: 39915 RVA: 0x00280C54 File Offset: 0x0027EE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x00280C64 File Offset: 0x0027EE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x00280C74 File Offset: 0x0027EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipOrnamentRequest other)
		{
		}

		// Token: 0x06009BEE RID: 39918 RVA: 0x00280C84 File Offset: 0x0027EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009BEF RID: 39919 RVA: 0x00280C94 File Offset: 0x0027EE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x00280CA4 File Offset: 0x0027EEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipOrnamentRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OutfitEquipOrnamentRequest._parser = new MessageParser<OutfitEquipOrnamentRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					OutfitEquipOrnamentRequest.OrnamentIdDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06009BF1 RID: 39921 RVA: 0x00280DB0 File Offset: 0x0027EFB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rDidpBJxzhcgLSsaHRIB()
		{
			return true;
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x00280DB8 File Offset: 0x0027EFB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipOrnamentRequest HxXgoDJ4fyjbICB7rMMV()
		{
			return null;
		}

		// Token: 0x040039D3 RID: 14803
		private static readonly MessageParser<OutfitEquipOrnamentRequest> _parser;

		// Token: 0x040039D4 RID: 14804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D5 RID: 14805
		private int _hasBits0;

		// Token: 0x040039D6 RID: 14806
		public const int OrnamentIdFieldNumber = 1;

		// Token: 0x040039D7 RID: 14807
		private static readonly int OrnamentIdDefaultValue;

		// Token: 0x040039D8 RID: 14808
		private int ornamentId_;

		// Token: 0x040039D9 RID: 14809
		internal static OutfitEquipOrnamentRequest QxDYEYJxFxSWg8YMxhmE;
	}
}
