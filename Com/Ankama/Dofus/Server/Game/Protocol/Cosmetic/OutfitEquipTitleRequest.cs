using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CA9 RID: 3241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipTitleRequest : IMessage<OutfitEquipTitleRequest>, IMessage, IEquatable<OutfitEquipTitleRequest>, IDeepCloneable<OutfitEquipTitleRequest>, IBufferMessage
	{
		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x00280734 File Offset: 0x0027E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipTitleRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06009BA7 RID: 39847 RVA: 0x00280744 File Offset: 0x0027E944
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

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x00280754 File Offset: 0x0027E954
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

		// Token: 0x06009BA9 RID: 39849 RVA: 0x00280764 File Offset: 0x0027E964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleRequest()
		{
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x00280774 File Offset: 0x0027E974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleRequest(OutfitEquipTitleRequest other)
		{
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x00280784 File Offset: 0x0027E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x00280794 File Offset: 0x0027E994
		// (set) Token: 0x06009BAD RID: 39853 RVA: 0x002807A4 File Offset: 0x0027E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleId
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

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x002807B4 File Offset: 0x0027E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTitleId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x002807C4 File Offset: 0x0027E9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearTitleId()
		{
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x002807D4 File Offset: 0x0027E9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x002807E4 File Offset: 0x0027E9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipTitleRequest other)
		{
			return true;
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x002807F4 File Offset: 0x0027E9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00280804 File Offset: 0x0027EA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x00280814 File Offset: 0x0027EA14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x00280824 File Offset: 0x0027EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x00280834 File Offset: 0x0027EA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x00280844 File Offset: 0x0027EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipTitleRequest other)
		{
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x00280854 File Offset: 0x0027EA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x00280864 File Offset: 0x0027EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x00280874 File Offset: 0x0027EA74
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipTitleRequest()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 4:
						OutfitEquipTitleRequest.TitleIdDefaultValue = 0;
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						OutfitEquipTitleRequest._parser = new MessageParser<OutfitEquipTitleRequest>(() => null);
						num2 = 4;
						continue;
					}
					break;
				}
				IL_97:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				goto IL_97;
			}
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x00280958 File Offset: 0x0027EB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rl9dJKJxMcKYwhIyrUcn()
		{
			return true;
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x00280960 File Offset: 0x0027EB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipTitleRequest OFVZBFJxuIeb5NbYYMm4()
		{
			return null;
		}

		// Token: 0x040039C3 RID: 14787
		private static readonly MessageParser<OutfitEquipTitleRequest> _parser;

		// Token: 0x040039C4 RID: 14788
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C5 RID: 14789
		private int _hasBits0;

		// Token: 0x040039C6 RID: 14790
		public const int TitleIdFieldNumber = 1;

		// Token: 0x040039C7 RID: 14791
		private static readonly int TitleIdDefaultValue;

		// Token: 0x040039C8 RID: 14792
		private int titleId_;

		// Token: 0x040039C9 RID: 14793
		private static OutfitEquipTitleRequest PK088SJxSf70ZQY4qIEl;
	}
}
