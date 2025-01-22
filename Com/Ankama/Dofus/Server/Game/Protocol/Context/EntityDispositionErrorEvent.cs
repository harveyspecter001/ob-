using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x0200081B RID: 2075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityDispositionErrorEvent : IMessage<EntityDispositionErrorEvent>, IMessage, IEquatable<EntityDispositionErrorEvent>, IDeepCloneable<EntityDispositionErrorEvent>, IBufferMessage
	{
		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060064F1 RID: 25841 RVA: 0x002274A0 File Offset: 0x002256A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityDispositionErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060064F2 RID: 25842 RVA: 0x002274B0 File Offset: 0x002256B0
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

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060064F3 RID: 25843 RVA: 0x002274C0 File Offset: 0x002256C0
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

		// Token: 0x060064F4 RID: 25844 RVA: 0x002274D0 File Offset: 0x002256D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDispositionErrorEvent()
		{
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x002274E0 File Offset: 0x002256E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDispositionErrorEvent(EntityDispositionErrorEvent other)
		{
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x002274F0 File Offset: 0x002256F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDispositionErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00227500 File Offset: 0x00225700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00227510 File Offset: 0x00225710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntityDispositionErrorEvent other)
		{
			return true;
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00227520 File Offset: 0x00225720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00227530 File Offset: 0x00225730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00227540 File Offset: 0x00225740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00227550 File Offset: 0x00225750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00227560 File Offset: 0x00225760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00227570 File Offset: 0x00225770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntityDispositionErrorEvent other)
		{
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00227580 File Offset: 0x00225780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00227590 File Offset: 0x00225790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x002275A0 File Offset: 0x002257A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntityDispositionErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					EntityDispositionErrorEvent._parser = new MessageParser<EntityDispositionErrorEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
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
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x0022766C File Offset: 0x0022586C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YKbAh6OzqYgyRvSbPWR2()
		{
			return true;
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x00227674 File Offset: 0x00225874
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntityDispositionErrorEvent rZClIdOzFZhgjVNcjGT2()
		{
			return null;
		}

		// Token: 0x04002371 RID: 9073
		private static readonly MessageParser<EntityDispositionErrorEvent> _parser;

		// Token: 0x04002372 RID: 9074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002373 RID: 9075
		private static EntityDispositionErrorEvent j0XcFQOzZxGkAu9TFdLy;
	}
}
