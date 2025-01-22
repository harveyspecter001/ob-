using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CB1 RID: 3249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipObjectRequest : IMessage<OutfitEquipObjectRequest>, IMessage, IEquatable<OutfitEquipObjectRequest>, IDeepCloneable<OutfitEquipObjectRequest>, IBufferMessage
	{
		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06009C12 RID: 39954 RVA: 0x00280FD8 File Offset: 0x0027F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipObjectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06009C13 RID: 39955 RVA: 0x00280FE8 File Offset: 0x0027F1E8
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

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06009C14 RID: 39956 RVA: 0x00280FF8 File Offset: 0x0027F1F8
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

		// Token: 0x06009C15 RID: 39957 RVA: 0x00281008 File Offset: 0x0027F208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectRequest()
		{
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x00281018 File Offset: 0x0027F218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectRequest(OutfitEquipObjectRequest other)
		{
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x00281028 File Offset: 0x0027F228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x00281038 File Offset: 0x0027F238
		// (set) Token: 0x06009C19 RID: 39961 RVA: 0x0028104C File Offset: 0x0027F24C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectSlot Slot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectSlot)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06009C1A RID: 39962 RVA: 0x0028105C File Offset: 0x0027F25C
		// (set) Token: 0x06009C1B RID: 39963 RVA: 0x0028106C File Offset: 0x0027F26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06009C1C RID: 39964 RVA: 0x0028107C File Offset: 0x0027F27C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasGid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x0028108C File Offset: 0x0027F28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearGid()
		{
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06009C1E RID: 39966 RVA: 0x0028109C File Offset: 0x0027F29C
		// (set) Token: 0x06009C1F RID: 39967 RVA: 0x002810AC File Offset: 0x0027F2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
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

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06009C20 RID: 39968 RVA: 0x002810BC File Offset: 0x0027F2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkinId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x002810CC File Offset: 0x0027F2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSkinId()
		{
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x002810DC File Offset: 0x0027F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x002810EC File Offset: 0x0027F2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipObjectRequest other)
		{
			return true;
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x002810FC File Offset: 0x0027F2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x0028110C File Offset: 0x0027F30C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x0028111C File Offset: 0x0027F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x0028112C File Offset: 0x0027F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x0028113C File Offset: 0x0027F33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x0028114C File Offset: 0x0027F34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipObjectRequest other)
		{
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x0028115C File Offset: 0x0027F35C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C2B RID: 39979 RVA: 0x0028116C File Offset: 0x0027F36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x0028117C File Offset: 0x0027F37C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipObjectRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						OutfitEquipObjectRequest.SkinIdDefaultValue = 0;
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 4:
						goto IL_B0;
					case 5:
						return;
					case 6:
						OutfitEquipObjectRequest._parser = new MessageParser<OutfitEquipObjectRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					OutfitEquipObjectRequest.GidDefaultValue = 0;
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
					}
				}
				IL_B0:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 6;
			}
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x002812A0 File Offset: 0x0027F4A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hHJKrdJ4eQG3SYJExVX3()
		{
			return true;
		}

		// Token: 0x06009C2E RID: 39982 RVA: 0x002812A8 File Offset: 0x0027F4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipObjectRequest rueRc5J43jPYfxJJyMdI()
		{
			return null;
		}

		// Token: 0x040039E3 RID: 14819
		private static readonly MessageParser<OutfitEquipObjectRequest> _parser;

		// Token: 0x040039E4 RID: 14820
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E5 RID: 14821
		private int _hasBits0;

		// Token: 0x040039E6 RID: 14822
		public const int SlotFieldNumber = 2;

		// Token: 0x040039E7 RID: 14823
		private ObjectSlot slot_;

		// Token: 0x040039E8 RID: 14824
		public const int GidFieldNumber = 1;

		// Token: 0x040039E9 RID: 14825
		private static readonly int GidDefaultValue;

		// Token: 0x040039EA RID: 14826
		private int gid_;

		// Token: 0x040039EB RID: 14827
		public const int SkinIdFieldNumber = 3;

		// Token: 0x040039EC RID: 14828
		private static readonly int SkinIdDefaultValue;

		// Token: 0x040039ED RID: 14829
		private int skinId_;

		// Token: 0x040039EE RID: 14830
		private static OutfitEquipObjectRequest ADU600J4Bm5c3nx3UMnl;
	}
}
