using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Script
{
	// Token: 0x02000175 RID: 373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CinematicEvent : IMessage<CinematicEvent>, IMessage, IEquatable<CinematicEvent>, IDeepCloneable<CinematicEvent>, IBufferMessage
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0019F770 File Offset: 0x0019D970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CinematicEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0019F780 File Offset: 0x0019D980
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0019F790 File Offset: 0x0019D990
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

		// Token: 0x0600110B RID: 4363 RVA: 0x0019F7A0 File Offset: 0x0019D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CinematicEvent()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0019F7B0 File Offset: 0x0019D9B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CinematicEvent(CinematicEvent other)
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0019F7C0 File Offset: 0x0019D9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CinematicEvent Clone()
		{
			return null;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0019F7D0 File Offset: 0x0019D9D0
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0019F7E0 File Offset: 0x0019D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CinematicId
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

		// Token: 0x06001110 RID: 4368 RVA: 0x0019F7F0 File Offset: 0x0019D9F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0019F800 File Offset: 0x0019DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CinematicEvent other)
		{
			return true;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0019F810 File Offset: 0x0019DA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0019F820 File Offset: 0x0019DA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0019F830 File Offset: 0x0019DA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0019F840 File Offset: 0x0019DA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0019F850 File Offset: 0x0019DA50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0019F860 File Offset: 0x0019DA60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CinematicEvent other)
		{
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0019F870 File Offset: 0x0019DA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0019F880 File Offset: 0x0019DA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0019F890 File Offset: 0x0019DA90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CinematicEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				CinematicEvent._parser = new MessageParser<CinematicEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0019F988 File Offset: 0x0019DB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xYVc4COvXUKgrlZ6lE8y()
		{
			return true;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0019F990 File Offset: 0x0019DB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CinematicEvent vZx2x0OvN1PRAMbSJygn()
		{
			return null;
		}

		// Token: 0x04000633 RID: 1587
		private static readonly MessageParser<CinematicEvent> _parser;

		// Token: 0x04000634 RID: 1588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000635 RID: 1589
		public const int CinematicIdFieldNumber = 1;

		// Token: 0x04000636 RID: 1590
		private int cinematicId_;

		// Token: 0x04000637 RID: 1591
		internal static CinematicEvent j28WliOvEVrHYorVwJwJ;
	}
}
