using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000373 RID: 883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountReleasedEvent : IMessage<MountReleasedEvent>, IMessage, IEquatable<MountReleasedEvent>, IDeepCloneable<MountReleasedEvent>, IBufferMessage
	{
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x001C7BE4 File Offset: 0x001C5DE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountReleasedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x001C7BF4 File Offset: 0x001C5DF4
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x001C7C04 File Offset: 0x001C5E04
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

		// Token: 0x06002974 RID: 10612 RVA: 0x001C7C14 File Offset: 0x001C5E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleasedEvent()
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x001C7C24 File Offset: 0x001C5E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleasedEvent(MountReleasedEvent other)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x001C7C34 File Offset: 0x001C5E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleasedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x001C7C44 File Offset: 0x001C5E44
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x001C7C54 File Offset: 0x001C5E54
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

		// Token: 0x06002979 RID: 10617 RVA: 0x001C7C64 File Offset: 0x001C5E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x001C7C74 File Offset: 0x001C5E74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountReleasedEvent other)
		{
			return true;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x001C7C84 File Offset: 0x001C5E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x001C7C94 File Offset: 0x001C5E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x001C7CA4 File Offset: 0x001C5EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x001C7CB4 File Offset: 0x001C5EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x001C7CC4 File Offset: 0x001C5EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x001C7CD4 File Offset: 0x001C5ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountReleasedEvent other)
		{
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x001C7CE4 File Offset: 0x001C5EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x001C7CF4 File Offset: 0x001C5EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x001C7D04 File Offset: 0x001C5F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountReleasedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					MountReleasedEvent._parser = new MessageParser<MountReleasedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x001C7DE8 File Offset: 0x001C5FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hQAtUEOrJk5DtdobwIym()
		{
			return true;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x001C7DF0 File Offset: 0x001C5FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountReleasedEvent zcuGmvOrGAjy4TYPUucB()
		{
			return null;
		}

		// Token: 0x04000EAC RID: 3756
		private static readonly MessageParser<MountReleasedEvent> _parser;

		// Token: 0x04000EAD RID: 3757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EAE RID: 3758
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000EAF RID: 3759
		private int mountId_;

		// Token: 0x04000EB0 RID: 3760
		private static MountReleasedEvent Orq36hOrOuBi8bcxNDQV;
	}
}
