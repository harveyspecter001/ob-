using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000363 RID: 867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountFeedRequest : IMessage<MountFeedRequest>, IMessage, IEquatable<MountFeedRequest>, IDeepCloneable<MountFeedRequest>, IBufferMessage
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x001C6D20 File Offset: 0x001C4F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountFeedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x001C6D30 File Offset: 0x001C4F30
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x001C6D40 File Offset: 0x001C4F40
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

		// Token: 0x060028B7 RID: 10423 RVA: 0x001C6D50 File Offset: 0x001C4F50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountFeedRequest()
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x001C6D60 File Offset: 0x001C4F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountFeedRequest(MountFeedRequest other)
		{
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x001C6D70 File Offset: 0x001C4F70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountFeedRequest Clone()
		{
			return null;
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x001C6D80 File Offset: 0x001C4F80
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x001C6D90 File Offset: 0x001C4F90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MountId
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x001C6DA0 File Offset: 0x001C4FA0
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x001C6DB4 File Offset: 0x001C4FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MountFeedRequest.Types.MountLocation MountLocation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MountFeedRequest.Types.MountLocation)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x001C6DC4 File Offset: 0x001C4FC4
		// (set) Token: 0x060028BF RID: 10431 RVA: 0x001C6DD4 File Offset: 0x001C4FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MountFoodUid
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

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x001C6DE4 File Offset: 0x001C4FE4
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x001C6DF4 File Offset: 0x001C4FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
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

		// Token: 0x060028C2 RID: 10434 RVA: 0x001C6E04 File Offset: 0x001C5004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x001C6E14 File Offset: 0x001C5014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountFeedRequest other)
		{
			return true;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x001C6E24 File Offset: 0x001C5024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x001C6E34 File Offset: 0x001C5034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x001C6E44 File Offset: 0x001C5044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x001C6E54 File Offset: 0x001C5054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x001C6E64 File Offset: 0x001C5064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x001C6E74 File Offset: 0x001C5074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountFeedRequest other)
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x001C6E84 File Offset: 0x001C5084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x001C6E94 File Offset: 0x001C5094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x001C6EA4 File Offset: 0x001C50A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountFeedRequest()
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
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				IL_5F:
				MountFeedRequest._parser = new MessageParser<MountFeedRequest>(() => null);
				num = 3;
				continue;
				goto IL_5F;
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x001C6F8C File Offset: 0x001C518C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AuZbM0OhY98qCkECo40B()
		{
			return true;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x001C6F94 File Offset: 0x001C5194
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountFeedRequest fmExynOhb2REnkW4uibW()
		{
			return null;
		}

		// Token: 0x04000E70 RID: 3696
		private static readonly MessageParser<MountFeedRequest> _parser;

		// Token: 0x04000E71 RID: 3697
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E72 RID: 3698
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000E73 RID: 3699
		private int mountId_;

		// Token: 0x04000E74 RID: 3700
		public const int MountLocationFieldNumber = 2;

		// Token: 0x04000E75 RID: 3701
		private MountFeedRequest.Types.MountLocation mountLocation_;

		// Token: 0x04000E76 RID: 3702
		public const int MountFoodUidFieldNumber = 3;

		// Token: 0x04000E77 RID: 3703
		private int mountFoodUid_;

		// Token: 0x04000E78 RID: 3704
		public const int QuantityFieldNumber = 4;

		// Token: 0x04000E79 RID: 3705
		private int quantity_;

		// Token: 0x04000E7A RID: 3706
		private static MountFeedRequest YAgnjkOhHAj6hmGSPh3o;

		// Token: 0x02000364 RID: 868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060028CF RID: 10447 RVA: 0x002B8B0C File Offset: 0x002B6D0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000365 RID: 869
			public enum MountLocation
			{
				// Token: 0x04000E7C RID: 3708
				[OriginalName("EQUIPPED")]
				Equipped,
				// Token: 0x04000E7D RID: 3709
				[OriginalName("INVENTORY")]
				Inventory,
				// Token: 0x04000E7E RID: 3710
				[OriginalName("STABLED")]
				Stabled,
				// Token: 0x04000E7F RID: 3711
				[OriginalName("MAP")]
				Map
			}
		}
	}
}
