using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C2A RID: 3114
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaFighterIdleEvent : IMessage<ArenaFighterIdleEvent>, IMessage, IEquatable<ArenaFighterIdleEvent>, IDeepCloneable<ArenaFighterIdleEvent>, IBufferMessage
	{
		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x002776B8 File Offset: 0x002758B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaFighterIdleEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x060095AE RID: 38318 RVA: 0x002776C8 File Offset: 0x002758C8
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

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x002776D8 File Offset: 0x002758D8
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

		// Token: 0x060095B0 RID: 38320 RVA: 0x002776E8 File Offset: 0x002758E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterIdleEvent()
		{
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x002776F8 File Offset: 0x002758F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterIdleEvent(ArenaFighterIdleEvent other)
		{
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00277708 File Offset: 0x00275908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterIdleEvent Clone()
		{
			return null;
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x00277718 File Offset: 0x00275918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x00277728 File Offset: 0x00275928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaFighterIdleEvent other)
		{
			return true;
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x00277738 File Offset: 0x00275938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00277748 File Offset: 0x00275948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x00277758 File Offset: 0x00275958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x00277768 File Offset: 0x00275968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00277778 File Offset: 0x00275978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00277788 File Offset: 0x00275988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaFighterIdleEvent other)
		{
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x00277798 File Offset: 0x00275998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x002777A8 File Offset: 0x002759A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x002777B8 File Offset: 0x002759B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaFighterIdleEvent()
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
					default:
						goto IL_35;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						ArenaFighterIdleEvent._parser = new MessageParser<ArenaFighterIdleEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
						{
							num2 = 3;
						}
						break;
					}
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x002778A0 File Offset: 0x00275AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pkjxneJXwGn1Pm6XTYHn()
		{
			return true;
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x002778A8 File Offset: 0x00275AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaFighterIdleEvent F8GNd2JXQtom8EMJaya6()
		{
			return null;
		}

		// Token: 0x040037C1 RID: 14273
		private static readonly MessageParser<ArenaFighterIdleEvent> _parser;

		// Token: 0x040037C2 RID: 14274
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C3 RID: 14275
		internal static ArenaFighterIdleEvent XxjIfJJXtm7CvJPu2QDF;
	}
}
