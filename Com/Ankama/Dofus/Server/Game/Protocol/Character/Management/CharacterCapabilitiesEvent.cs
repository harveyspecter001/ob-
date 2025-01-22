using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000947 RID: 2375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCapabilitiesEvent : IMessage<CharacterCapabilitiesEvent>, IMessage, IEquatable<CharacterCapabilitiesEvent>, IDeepCloneable<CharacterCapabilitiesEvent>, IBufferMessage
	{
		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x0023E348 File Offset: 0x0023C548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterCapabilitiesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x0023E358 File Offset: 0x0023C558
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

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060072F7 RID: 29431 RVA: 0x0023E368 File Offset: 0x0023C568
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

		// Token: 0x060072F8 RID: 29432 RVA: 0x0023E378 File Offset: 0x0023C578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCapabilitiesEvent()
		{
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0023E388 File Offset: 0x0023C588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCapabilitiesEvent(CharacterCapabilitiesEvent other)
		{
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x0023E398 File Offset: 0x0023C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCapabilitiesEvent Clone()
		{
			return null;
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x0023E3A8 File Offset: 0x0023C5A8
		// (set) Token: 0x060072FC RID: 29436 RVA: 0x0023E3B8 File Offset: 0x0023C5B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GuildEmblemSymbolCategory
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

		// Token: 0x060072FD RID: 29437 RVA: 0x0023E3C8 File Offset: 0x0023C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x0023E3D8 File Offset: 0x0023C5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCapabilitiesEvent other)
		{
			return true;
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x0023E3E8 File Offset: 0x0023C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x0023E3F8 File Offset: 0x0023C5F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x0023E408 File Offset: 0x0023C608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x0023E418 File Offset: 0x0023C618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0023E428 File Offset: 0x0023C628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0023E438 File Offset: 0x0023C638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCapabilitiesEvent other)
		{
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x0023E448 File Offset: 0x0023C648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0023E458 File Offset: 0x0023C658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x0023E468 File Offset: 0x0023C668
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCapabilitiesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					CharacterCapabilitiesEvent._parser = new MessageParser<CharacterCapabilitiesEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x0023E54C File Offset: 0x0023C74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BNGr3aJ3JVhMUFOb7CUZ()
		{
			return true;
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x0023E554 File Offset: 0x0023C754
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCapabilitiesEvent AWcWq1J3GYdpJQJ3pOfY()
		{
			return null;
		}

		// Token: 0x04002835 RID: 10293
		private static readonly MessageParser<CharacterCapabilitiesEvent> _parser;

		// Token: 0x04002836 RID: 10294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002837 RID: 10295
		public const int GuildEmblemSymbolCategoryFieldNumber = 1;

		// Token: 0x04002838 RID: 10296
		private int guildEmblemSymbolCategory_;

		// Token: 0x04002839 RID: 10297
		internal static CharacterCapabilitiesEvent DdEMcTJ3OP7YOfT6V29R;
	}
}
