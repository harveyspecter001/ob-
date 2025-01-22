using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CD5 RID: 3285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEntityLookChangedEvent : IMessage<OutfitEntityLookChangedEvent>, IMessage, IEquatable<OutfitEntityLookChangedEvent>, IDeepCloneable<OutfitEntityLookChangedEvent>, IBufferMessage
	{
		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06009E09 RID: 40457 RVA: 0x002837A0 File Offset: 0x002819A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitEntityLookChangedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x002837B0 File Offset: 0x002819B0
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

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x002837C0 File Offset: 0x002819C0
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

		// Token: 0x06009E0C RID: 40460 RVA: 0x002837D0 File Offset: 0x002819D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEntityLookChangedEvent()
		{
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x002837E0 File Offset: 0x002819E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEntityLookChangedEvent(OutfitEntityLookChangedEvent other)
		{
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x002837F0 File Offset: 0x002819F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEntityLookChangedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x00283800 File Offset: 0x00281A00
		// (set) Token: 0x06009E10 RID: 40464 RVA: 0x00283810 File Offset: 0x00281A10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string OutfitUuid
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

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x00283820 File Offset: 0x00281A20
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x00283830 File Offset: 0x00281A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLook EntityLook
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

		// Token: 0x06009E13 RID: 40467 RVA: 0x00283840 File Offset: 0x00281A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x00283850 File Offset: 0x00281A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEntityLookChangedEvent other)
		{
			return true;
		}

		// Token: 0x06009E15 RID: 40469 RVA: 0x00283860 File Offset: 0x00281A60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x00283870 File Offset: 0x00281A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x00283880 File Offset: 0x00281A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x00283890 File Offset: 0x00281A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009E19 RID: 40473 RVA: 0x002838A0 File Offset: 0x00281AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009E1A RID: 40474 RVA: 0x002838B0 File Offset: 0x00281AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEntityLookChangedEvent other)
		{
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x002838C0 File Offset: 0x00281AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009E1C RID: 40476 RVA: 0x002838D0 File Offset: 0x00281AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x002838E0 File Offset: 0x00281AE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEntityLookChangedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					OutfitEntityLookChangedEvent._parser = new MessageParser<OutfitEntityLookChangedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x002839C4 File Offset: 0x00281BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kJg3YLJ4qUfXfrBFKdD6()
		{
			return true;
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x002839CC File Offset: 0x00281BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEntityLookChangedEvent E4AL57J4FCJSADXV0o5I()
		{
			return null;
		}

		// Token: 0x04003A85 RID: 14981
		private static readonly MessageParser<OutfitEntityLookChangedEvent> _parser;

		// Token: 0x04003A86 RID: 14982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A87 RID: 14983
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x04003A88 RID: 14984
		private string outfitUuid_;

		// Token: 0x04003A89 RID: 14985
		public const int EntityLookFieldNumber = 2;

		// Token: 0x04003A8A RID: 14986
		private EntityLook entityLook_;

		// Token: 0x04003A8B RID: 14987
		internal static OutfitEntityLookChangedEvent iJ6BYIJ4Znyj7KdNl51T;
	}
}
